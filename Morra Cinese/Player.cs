using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Morra_Cinese
{
    public class Player
    {
        public string nome;
        public Image immagine;
        public Giocata giocata;
    }
    public enum Giocata
    {
        sasso, carta, forbici
    }
}
