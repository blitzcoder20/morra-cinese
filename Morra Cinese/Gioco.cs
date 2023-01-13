using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Morra_Cinese.Properties;

namespace Morra_Cinese
{
    public partial class Gioco : Form
    {

        int count = 0;
        PictureBox arrow = new PictureBox();
        public Morra morra;
        bool chiudiApplicazione = true;
        DataBaseManager db = new DataBaseManager(System.Configuration.ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
        public RecordDb giocatore1;
        public RecordDb giocatore2;
        int nris;

        public Gioco()
        {
            InitializeComponent();

        }

        private void Gioco_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chiudiApplicazione)
                Application.Exit();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            chiudiApplicazione = false;
            morra.TornaAlMenu(this);
        }

        private void Gioco_Load(object sender, EventArgs e)
        {

            pcb_Player1.Image = Resources.puntoInterrogativo;
            pcb_Player2.Image = Resources.puntoInterrogativo;
            lbl_Player1.Text = morra.player1.nome;
            lbl_Player2.Text = morra.Player2.nome;
            arrow.Image = Resources.SmoothArrow;

            arrow.SizeMode = PictureBoxSizeMode.StretchImage;
            arrow.SetBounds(lbl_Player1.Location.X + lbl_Player1.Width / 2 - 10, lbl_Player1.Location.Y - 30, 20, 20);
            Controls.Add(arrow);
        }


        private void Gioco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                morra.EseguiMossa(Giocata.sasso);
            }
            else if (e.KeyCode == Keys.D2)
            {
                morra.EseguiMossa(Giocata.carta);
            }
            else if (e.KeyCode == Keys.D3)
            {
                morra.EseguiMossa(Giocata.forbici);
            }
            else return;
            count++;
            if (count == 1)
            {
                arrow.Left = lbl_Player2.Location.X + lbl_Player2.Width / 2 - 10;
                arrow.Top = lbl_Player2.Location.Y - 30;
            }
            if (morra.singlePlayer || count == 2)
            {
                if (morra.Pareggio())
                {
                    pcb_Player1.Image = morra.player1.immagine;
                    pcb_Player2.Image = morra.Player2.immagine;
                    giocatore1.pareggi++;
                    giocatore2.pareggi++;
                    nris = 0;
                    MessageBox.Show("Pareggio");
                    FineGioco();
                    return;
                }
                Player vincitore = morra.Vittoria();
                if (vincitore != null)
                {
                    pcb_Player1.Image = morra.player1.immagine;
                    pcb_Player2.Image = morra.Player2.immagine;
                    MessageBox.Show("Ha vinto " + vincitore.nome);
                    if (vincitore.nome == giocatore1.nickname)
                    {
                        giocatore1.vittorie++;
                        giocatore2.sconfitte++;
                        nris = 1;
                    }
                    else
                    {
                        giocatore2.vittorie++;
                        giocatore1.sconfitte++;
                        nris = -1;
                    }
                    FineGioco();
                }
            }
        }

        private void FineGioco()
        {
            db.SalvaGiocatore(giocatore1);
            db.SalvaGiocatore(giocatore2);
            db.SalvaPartita(giocatore1, giocatore2, nris);
            count = 0;
            DialogResult ris = MessageBox.Show("Vuoi giocare di nuovo?", "Gioco finito", MessageBoxButtons.YesNo);
            if (ris == DialogResult.Yes)
            {
                morra.Reset();
                pcb_Player1.Image = Resources.puntoInterrogativo;
                pcb_Player2.Image = Resources.puntoInterrogativo;
                arrow.Left = lbl_Player1.Location.X + lbl_Player1.Width / 2 - 10;
                arrow.Top = lbl_Player1.Location.Y - 30;
            }
            else
            {
                chiudiApplicazione = false;
                morra.TornaAlMenu(this);
            }
        }
    }
}
