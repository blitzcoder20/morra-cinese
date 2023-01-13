using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morra_Cinese
{
    public class RecordDb
    {
        public int vittorie;
        public int sconfitte;
        public int pareggi;
        public string nome;
        public string password;
        public string cognome;
        public string email;
        public string nickname;
        public int id;
        public string DataIscrizione;
        public int PercentualeVittorie;

        public RecordDb(int id, string nickname, string email, string nome, string cognome, int pareggi, int sconfitte, int vittorie, string DataIscrizione,string password)
        {
            this.password = password;
            this.DataIscrizione = DataIscrizione;
            this.id = id;
            this.nickname = nickname;
            this.email = email;
            this.nome = nome;
            this.cognome = cognome;
            this.pareggi = pareggi;
            this.sconfitte = sconfitte;
            this.vittorie = vittorie;
        }
        public RecordDb()
        {

        }
    }
}
