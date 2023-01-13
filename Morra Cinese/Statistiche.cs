using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morra_Cinese
{
    public partial class Statistiche : Form
    {
        public Form formMenu;
        bool chiudiApplicazione = true;

        DataBaseManager db = new DataBaseManager(System.Configuration.ConfigurationManager.ConnectionStrings["Test"].ConnectionString);

        public Statistiche()
        {
            InitializeComponent();
        }

        private void Statistiche_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chiudiApplicazione)
                Application.Exit();
        }

        private void Statistiche_Load(object sender, EventArgs e)
        {
            CaricaTabella();
        }

        void CaricaTabella()
        {
            List<RecordDb> lista = db.RendiTuttiDati();
            lista = Riordina(lista);
            foreach (RecordDb riga in lista)
            {
                tbl_Classifica.Rows.Add(riga.nickname, riga.vittorie, riga.pareggi, riga.sconfitte, riga.PercentualeVittorie);
            }

        }

        private List<RecordDb> Riordina(List<RecordDb> lista)
        {
            List<RecordDb> Ordinata = new List<RecordDb>();
            while (lista.Count != 0)
            {
                RecordDb max = lista[0];
                for (int i = 1; i < lista.Count; i++)
                {
                    if (lista[i].vittorie > max.vittorie)
                    {
                        max = lista[i];
                    }
                }
                Ordinata.Add(max);
                lista.Remove(max);
            }
            return Ordinata;
        }

        private void btn_Conferma_Click(object sender, EventArgs e)
        {
            RecordDb partita = db.TrovaPartite(txt_Nick1.Text, txt_Nick2.Text);
            if (partita == null)
            {
                MessageBox.Show("Errore durante la ricerca controlla i nickname");
                return;
            }
            lbl_Vittorie1.Text = "Vittorie:" + partita.vittorie;
            lbl_Pareggi1.Text = "Pareggi:" + partita.pareggi;
            lbl_Sconfitte1.Text = "Sconfitte:" + partita.sconfitte;
            lbl_Vittorie2.Text = "Vittorie:" + partita.sconfitte;
            lbl_Pareggi2.Text = "Pareggi:" + partita.pareggi;
            lbl_Sconfitte2.Text = "Sconfitte:" + partita.vittorie;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabMenu"])
            {
                chiudiApplicazione = false;
                this.Close();
                formMenu.Show();
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Conferma_gg_Click(object sender, EventArgs e)
        {
            RecordDb giocatore = db.RendiGiocatore(db.RecuperaIDUtente(txt_Nick_gg.Text));
            if (giocatore == null)
            {
                MessageBox.Show("Errore durante la ricerca controllare i campi");
                return;
            }
            
            lbl_Vittoriegg.Text = "Vittorie:" + giocatore.vittorie;
            lbl_Pareggigg.Text = "Pareggi:" + giocatore.pareggi;
            lbl_Sconfittegg.Text = "Sconfitte:" + giocatore.sconfitte;

        }
    }
}
