using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Morra_Cinese
{
    class DataBaseManager : IDisposable
    {
        SqlConnection conn;
        bool invertimento = false;
        public DataBaseManager(string connectionString)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        public int Registrazione(string email, string nome, string cognome, string nick, string pwd)
        {
            int id = 0;
            try
            {

                using (SqlCommand cmd = new SqlCommand("INSERT INTO Giocatori(email,nickname,Nome,Cognome,password,DataIscrizione,IP_Address)OUTPUT INSERTED.ID_GIOCATORE VALUES(@email,@nick,@nome,@cognome,@password,@data,@ip)", conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", pwd);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cognome", cognome);
                    cmd.Parameters.AddWithValue("@nick", nick);
                    cmd.Parameters.AddWithValue("@data", DateTime.Today);
                    cmd.Parameters.AddWithValue("@ip", GetLocalIPAddress());
                    id = (int)cmd.ExecuteScalar();

                }
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Vittorie_Giocatori(ID_GIOCATORE) VALUES(@id)", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'operazione");
                return -1;
            }
            return id;

        }

        public int LogIn(string nick, string password)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("select ID_GIOCATORE from Giocatori where  nickname='" + nick + "' and password='" + password + "'", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return int.Parse(reader["ID_GIOCATORE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'effettuare il login");
            }
            return -1;
        }

        public int RecuperaIDUtente(string nick)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("select ID_GIOCATORE from Giocatori where  nickname='" + nick + "'", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return int.Parse(reader["ID_GIOCATORE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return -1;
        }


        public RecordDb RendiGiocatore(int id)
        {
            RecordDb tmp = new RecordDb();
            tmp.id = id;
            try
            {
                using (SqlCommand cmd = new SqlCommand("select * from Giocatori where ID_GIOCATORE='" + id + "'", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tmp.nome = (string)reader.GetValue(reader.GetOrdinal("Nome"));
                            tmp.cognome = (string)reader.GetValue(reader.GetOrdinal("Cognome"));
                            tmp.nickname = (string)reader.GetValue(reader.GetOrdinal("nickname"));
                            tmp.email = (string)reader.GetValue(reader.GetOrdinal("email"));
                            tmp.DataIscrizione = reader.GetValue(reader.GetOrdinal("DataIscrizione")).ToString();
                            tmp.password = (string)reader.GetValue(reader.GetOrdinal("password"));
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("select * from Vittorie_Giocatori where ID_GIOCATORE='" + id + "'", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tmp.vittorie = (int)reader.GetValue(reader.GetOrdinal("Vittorie"));
                            tmp.pareggi = (int)reader.GetValue(reader.GetOrdinal("Pareggi"));
                            tmp.sconfitte = (int)reader.GetValue(reader.GetOrdinal("Sconfitte"));
                            return tmp;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public RecordDb RendiPartita(int ID_PARTITA)
        {
            using (SqlCommand cmd = new SqlCommand("Select * from Partite where ID_PARTITA=" + ID_PARTITA, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RecordDb record = new RecordDb();
                        record.id = (int)reader.GetValue(reader.GetOrdinal("ID_PARTITA"));
                        record.vittorie = (int)reader.GetValue(reader.GetOrdinal("Vittorie"));
                        record.pareggi = (int)reader.GetValue(reader.GetOrdinal("Pareggi"));
                        record.sconfitte = (int)reader.GetValue(reader.GetOrdinal("Sconfitte"));
                        return record;
                    }
                }
            }
            return null;
        }

        public void SalvaGiocatore(RecordDb record)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Vittorie_Giocatori SET Vittorie = @vittorie, Pareggi= @pareggi, Sconfitte= @sconfitte  Where ID_GIOCATORE = @id", conn))
            {
                cmd.Parameters.AddWithValue("@vittorie", record.vittorie);
                cmd.Parameters.AddWithValue("@pareggi", record.pareggi);
                cmd.Parameters.AddWithValue("@sconfitte", record.sconfitte);
                cmd.Parameters.AddWithValue("@id", record.id);
                cmd.ExecuteNonQuery();
            }
        }

        private int CreaPartita(int id1, int id2)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Partite(ID_GIOCATORE1,ID_GIOCATORE2) OUTPUT INSERTED.ID_PARTITA VALUES (@id1,@id2)", conn))
            {
                cmd.Parameters.AddWithValue("@id1", id1);
                cmd.Parameters.AddWithValue("@id2", id2);
                return (int)cmd.ExecuteScalar();
            }
        }

        public void SalvaPartita(RecordDb giocatore1, RecordDb giocatore2,int nris)
        {
            int ID_PARTITA = RecuperaIDPartita(giocatore1.id, giocatore2.id);
            if (ID_PARTITA == -1)
                ID_PARTITA = CreaPartita(giocatore1.id, giocatore2.id);
            if (invertimento)
            {
                RecordDb tmp = giocatore1;
                giocatore1 = giocatore2;
                giocatore2 = tmp;
                nris *= -1;
            }
            int vittoria = 0;
            int pareggio = 0;
            int sconfitta = 0;
            if (nris==1)
                vittoria = 1;
            if (nris == 0)
                pareggio = 1;
            if (nris == -1)
                sconfitta = 1;
            using (SqlCommand cmd = new SqlCommand("UPDATE Partite SET Vittorie = Vittorie+@vittorie, Pareggi=Pareggi+@pareggi, Sconfitte= Sconfitte+@sconfitte Where ID_PARTITA = @partita", conn))
            {
                cmd.Parameters.AddWithValue("@vittorie", vittoria);
                cmd.Parameters.AddWithValue("@pareggi",pareggio);
                cmd.Parameters.AddWithValue("@sconfitte",sconfitta);
                cmd.Parameters.AddWithValue("@partita", ID_PARTITA);
                cmd.ExecuteNonQuery();
            }
        }

        public int RecuperaIDPartita(int id1, int id2)
        {
            using (SqlCommand cmd = new SqlCommand("select ID_PARTITA from Partite where ID_GIOCATORE1=" + id1 + " and ID_GIOCATORE2=" + id2, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        invertimento = false;
                        return (int)reader.GetValue(reader.GetOrdinal("ID_PARTITA"));
                    }
                }
            }
            using (SqlCommand cmd = new SqlCommand("select ID_PARTITA from Partite where ID_GIOCATORE1=" + id2 + " and ID_GIOCATORE2=" + id1, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        invertimento = true;
                        return (int)reader.GetValue(reader.GetOrdinal("ID_PARTITA"));
                    }
                }
            }
            return -1;
        }

        public List<RecordDb> RendiTuttiDati()
        {
            List<RecordDb> righe = new List<RecordDb>();
            using (SqlCommand cmd = new SqlCommand("SELECT nickname,Vittorie,Pareggi,Sconfitte FROM Giocatori INNER JOIN Vittorie_Giocatori ON Giocatori.ID_GIOCATORE = Vittorie_Giocatori.ID_GIOCATORE ", conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RecordDb tmp = new RecordDb();
                        tmp.nickname = reader.GetValue(reader.GetOrdinal("Nickname")).ToString();
                        tmp.vittorie = int.Parse(reader.GetValue(reader.GetOrdinal("Vittorie")).ToString());
                        tmp.pareggi = int.Parse(reader.GetValue(reader.GetOrdinal("Pareggi")).ToString());
                        tmp.sconfitte = int.Parse(reader.GetValue(reader.GetOrdinal("Sconfitte")).ToString());
                        if (tmp.vittorie + tmp.pareggi + tmp.sconfitte != 0)
                            tmp.PercentualeVittorie = tmp.vittorie * 100 / (tmp.vittorie + tmp.pareggi + tmp.sconfitte);
                        else
                            tmp.PercentualeVittorie = 0;
                        righe.Add(tmp);
                    }
                }
            }
            return righe;
        }

        public RecordDb TrovaPartite(string text1, string text2)
        {
            RecordDb partita = RendiPartita(RecuperaIDPartita(RecuperaIDUtente(text1), RecuperaIDUtente(text2)));
            if (partita == null)
            {
                partita = RendiPartita(RecuperaIDPartita(RecuperaIDUtente(text2), RecuperaIDUtente(text1)));
                if (partita == null)
                    return null;
                int tmp = 0;
                tmp = partita.sconfitte;
                partita.sconfitte = partita.vittorie;
                partita.vittorie = tmp;
            }
            return partita;
        }

        private static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        public void Dispose()
        {
            conn.Close();
            conn.Dispose();
        }
    }
}
