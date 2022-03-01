using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class Punteggio
    {
        public static int value = 0;
        public static string punteggio = $"Punteggio: {value}";
        static Label _lblPunteggio;
        static Panel _pnlPunteggio;

        public Punteggio(Label lblPunteggio, Panel pnlPunteggio)
        {
            _lblPunteggio = lblPunteggio;
            _pnlPunteggio = pnlPunteggio;
            _lblPunteggio.Location = new Point(_pnlPunteggio.Width / 2 - 75, 0);
            _lblPunteggio.Text = punteggio;
        }
        public void SegnaPunti()
        {
            punteggio = "Punteggio: ";
            value += 1;
            punteggio += value;
        }
        public void Visualizza()
        {
            _lblPunteggio.Text = punteggio;
        }
    }
}
