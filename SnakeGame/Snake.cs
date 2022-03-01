using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    internal class Snake : CampoData
    {
        public List<PictureBox> immagine = new List<PictureBox>();
        public SnakeData data;
        public Snake(PictureBox testa, PictureBox corpo, PictureBox coda)
        {
            immagine.Add(testa);
            immagine.Add(corpo);
            immagine.Add(coda);

            SnakeData.lunghezzaIniziale = immagine.Count;
            SnakeData data = new SnakeData();
            for (int i = 0; i < SnakeData.lunghezzaIniziale; i++)
            {
                immagine[i].Location = data.coords[i];
            }
            this.data = data;
        }
        public Snake(ref PictureBox testa, ref PictureBox coda, ref PictureBox[] corpo)
        {
            immagine.Add(testa);
            immagine.AddRange(corpo);
            immagine.Add(coda);


            SnakeData.lunghezzaIniziale = immagine.Count;
            SnakeData data = new SnakeData();
            for (int i = 0; i < SnakeData.lunghezzaIniziale; i++)
            {
                immagine[i].Location = data.coords[i];
            }
            this.data = data;
        }
        public Snake() { }

        public void Visualizza()
        {
            for (int i = 0; i < immagine.Count; i++)
            {
                immagine[i].Location = data.coords[i];
                immagine[i].BackColor = data.colore;
            }
        }
        public void Cancella()
        {
            for (int i = 0; i < immagine.Count; i++)
            {
                immagine[i].Location = data.coords[i];
                immagine[i].BackColor = Color.Black;
            }
        }

        internal void Allunga()
        {
            Point point = data.coords[data.coords.Count - 1];
            data.coords.Add(point);
        }

        internal bool IsCannibale()
        {
            int metà = data.coords.Count / 2;
            for (int i = 0; i < metà; i++)
            {
                for (int j = data.coords.Count - 1; j >= metà; j--)
                {
                    if (data.coords[i] == data.coords[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Muovi()
        {
            for (int i = data.coords.Count - 1; i > 0; i--)
            {
                data.coords[i] = data.coords[i - 1];
            }
            switch (data.direction)
            {
                case Direction.UP:
                    data.coords[0].Offset(0, -DimensioneCella);
                    break;
                case Direction.DOWN:
                    data.coords[0].Offset(0, DimensioneCella);
                    break;
                case Direction.LEFT:
                    data.coords[0].Offset(-DimensioneCella, 0);
                    break;
                case Direction.RIGHT:
                    data.coords[0].Offset(DimensioneCella, 0);
                    break;
            }
        }
        internal Direction GetDirection(Keys tastoPremuto)
        {
            switch (tastoPremuto)
            {
                case Keys.Up:
                    return Direction.UP;
                case Keys.Down:
                    return Direction.DOWN;
                case Keys.Left:
                    return Direction.LEFT;
                case Keys.Right:
                    return Direction.RIGHT;
            }
            return data.direction;
        }

        //public void Paint_Paint(object sender, PaintEventArgs e)
        //{
        //    for (int i = 0; i < _data.immagine.Count; i++)
        //    {
        //        //Graphics g = e.Graphics;
        //        //g.FillRectangle(_data.brush, _data.immagine[i]);
        //        _data.immagine[i].BackColor = _data.colore;
        //    }
        //}
        //public Snake()
        //{
        //    for (int i = 0; i < data.x.Count; i++)
        //    {
        //        data.coords.Add(new Point(data.x[i], data.y[i]));
        //    }
        //    foreach (var point in data.coords)
        //    {
        //        data.segmentoCorpo = new PictureBox()
        //        {
        //            Location = point,
        //            Width = Campo.data.dimensioneCelle,
        //            Height = Campo.data.dimensioneCelle,
        //            BackColor = data.colore
        //        };
        //        data.immagine.Add(data.segmentoCorpo);
        //    }
        //}
    }
}
