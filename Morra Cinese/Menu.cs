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
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();       
        }

        private void btn_Single_Click(object sender, EventArgs e)
        {
            Dati d = new Dati();
            d.singlePlayer = true;
            d.passaMenu = this;
            d.Show();
            this.Hide();
           
        }

        private void btn_Regole_Click(object sender, EventArgs e)
        {
            Regole r = new Regole();
            this.Hide();
            r.Show();
            r.regoleToMenu = this;
        }

        private void btn_Multi_Click(object sender, EventArgs e)
        {
            Dati d = new Dati();
            d.singlePlayer = false;
            d.passaMenu = this;
            d.Show();
            this.Hide();

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Statistiche_Click(object sender, EventArgs e)
        {
            Statistiche s = new Statistiche();
            s.Show();
            s.formMenu = this;
            this.Hide();
        }
    }

}
