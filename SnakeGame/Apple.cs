using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class Apple : Campo
    {
        static Random rnd = new Random();
        public Point posizione;
        public PictureBox immagine;

        public Apple()
        {
            immagine = new PictureBox() 
            {
                BackColor = Color.Red,
                Height = data.DimensioneCella,
                Width = data.DimensioneCella
            };
            Muovi();
        }
        int count = 100;
        public void Cancella()
        {
            immagine.Visible = false;
        }
        public void Visualizza()
        {
            if (count > 0)
            {
                immagine.Visible = true;
                count--;
            }
        }

        public void Muovi()
        {
            if (!immagine.Visible && count == 0)
            {
                posizione = new Point(
                rnd.Next(0, data.Righe - 1) * data.DimensioneCella,
                rnd.Next(0, data.Colonne - 1) * data.DimensioneCella
                );
                immagine.Location = posizione;
            }
            
        }
    }
}
