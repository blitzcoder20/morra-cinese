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
    public partial class Regole : Form
    {
        public Form regoleToMenu;
        bool chiusoX = true;
        public Regole()
        {
            InitializeComponent();
        }

        private void btn_ChangeForm_Click(object sender, EventArgs e)
        {
            regoleToMenu.Show();
            chiusoX = false;
            this.Close();
           
        }

        private void Regole_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(chiusoX)
            Application.Exit();
        }
    }
}
