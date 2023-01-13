using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Morra_Cinese.Properties;

namespace Morra_Cinese
{
    public class Morra
    {
        private Form formMenu;
        private bool _singlePlayer;
        private Player _player1;
        private Player _player2;
        private bool turnoPlayer = false; //false:giocatore1 true:giocatore2

        public Player player1
        {
            get
            {
                return _player1;
            }

            set
            {
                _player1 = value;
            }
        }

        public Player Player2
        {
            get
            {
                return _player2;
            }

            set
            {
                _player2 = value;
            }
        }

        public bool singlePlayer
        {
            get
            {
                return _singlePlayer;
            }
        }

        public Morra(Form menu, string nickPlayer1)
        {
            _singlePlayer = true;
            this.formMenu = menu;
            _player1 = new Player();
            _player1.nome = nickPlayer1;
            _player2 = new Player();
            _player2.nome = "Computer";
        }
        public Morra(Form menu, string nickPlayer1, string nickPlayer2)
        {
            _singlePlayer = false;
            this.formMenu = menu;
            _player1 = new Player();
            _player1.nome = nickPlayer1;
            _player2 = new Player();
            _player2.nome = nickPlayer2;

        }
        public void TornaAlMenu(Form formAttuale)
        {
            formAttuale.Close();
            formMenu.Show();
        }

        public bool Pareggio()
        {
            if ((Giocata)_player1.giocata == (Giocata)_player2.giocata)
                return true;
            return false;
        }
        public Player Vittoria()
        {
            if (_player1.giocata == Giocata.sasso && _player2.giocata == Giocata.forbici || _player1.giocata == Giocata.forbici && _player2.giocata == Giocata.carta || _player1.giocata == Giocata.carta && _player2.giocata == Giocata.sasso)
            {
                return _player1;
            }
            else if (_player2.giocata == Giocata.sasso && _player1.giocata == Giocata.forbici || _player2.giocata == Giocata.forbici && _player1.giocata == Giocata.carta || _player2.giocata == Giocata.carta && _player1.giocata == Giocata.sasso)
            {
                return _player2;
            }
            return null;
        }
        public void Reset()
        {
            string tmp = _player1.nome;
            _player1 = new Player();
            _player1.nome = tmp;
            tmp = _player2.nome;
            _player2 = new Player();
            _player2.nome = tmp;
            turnoPlayer = !turnoPlayer;
        }
        public void EseguiMossa(Giocata g)
        {
            
            if (!turnoPlayer || _singlePlayer)
            {
                _player1.giocata = g;
                _player1.immagine = GetImage(g);
            }
            if(_singlePlayer)
            {
                Random rnd = new Random();
                _player2.giocata = (Giocata)rnd.Next(0, 3);
                _player2.immagine = GetImage(_player2.giocata);
                
            }
            else if(turnoPlayer && !_singlePlayer)
            {             
                    _player2.giocata = g;
                    _player2.immagine = GetImage(g);
            }
            turnoPlayer = !turnoPlayer;
         

        }
        private Image GetImage(Giocata giocata)
        {
            if (giocata == Giocata.carta)
                return Resources.carta;
            else if (giocata == Giocata.forbici)
                return Resources.forbici;
            else if (giocata == Giocata.sasso)
                return Resources.sasso;
            return null;
        }

    }
}
