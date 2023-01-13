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
    public partial class Dati : Form
    {
        public Form passaMenu;
        public bool singlePlayer;
        bool chiudiApplicazione = true;
        bool registrazione = false;
        int countUtentiMessi = 0;
        RecordDb g1=new RecordDb();
        RecordDb g2=new RecordDb();
        DataBaseManager db = new DataBaseManager(System.Configuration.ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
      
        public Dati()
        {
            InitializeComponent();
        }

        private void btn_Conferma_Click(object sender, EventArgs e)
        {
            int id=-1;

            if (!registrazione)
            {
                 id=db.LogIn(txt_Nick.Text, txt_Pwd.Text);
                countUtentiMessi++;
            
            }
            else if (txt_Pwd.Text == txt_Pwd2.Text)
            {
               id=  db.Registrazione(txt_email.Text, txt_Nome.Text, txt_Cognome.Text, txt_Nick.Text, txt_Pwd.Text);
               
                countUtentiMessi++;
          
            }
            if (id != -1)
            {
                if (countUtentiMessi == 1)
                    g1 = db.RendiGiocatore(id);
                if (countUtentiMessi == 2)
                    g2 = db.RendiGiocatore(id);
                if (singlePlayer)
                    g2 = db.RendiGiocatore(1);
            }
            else MessageBox.Show("Errore nell'effetture il login");
            if ((singlePlayer || countUtentiMessi==2) && id!=-1 )
            {
                MessageBox.Show("login effettuato correttamente");
                chiudiApplicazione = false;
                Gioco gg = new Gioco();
    
                if (singlePlayer)
                    gg.morra = new Morra(passaMenu,g1.nickname);
                else gg.morra = new Morra(passaMenu, g1.nickname, g2.nickname);
                gg.giocatore1 = db.RendiGiocatore(id);
                gg.giocatore1 = g1;
                gg.giocatore2 = g2;
                gg.Show();

                this.Close();
                return;
            }
       
            if(id!=-1)
            {
                foreach (Control item in Controls)
                {
                    if(item is TextBox)
                    item.Text = "";
                }
                foreach (Control item in panel1.Controls)
                {
                    if(item is TextBox)
                    item.Text = "";
                }
                panel1.Visible = false;
              
                lbl_title.Text = "Login giocatore 2";
            }
         
           
        }

        private void Dati_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chiudiApplicazione)
                Application.Exit();
        }

  

        private void button1_Click(object sender, EventArgs e)
        {

            if (!registrazione)
            {
                panel1.Visible = true;
                registrazione = !registrazione;
            }
            else
            {
                panel1.Visible = false;
                registrazione = !registrazione;
            }
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
        }
    }
}
