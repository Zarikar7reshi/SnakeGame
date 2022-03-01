using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    class SnakeData
    {
        public static int lunghezzaIniziale;

        public List<int> x = new List<int>();
        public List<int> y = new List<int>();

        public List<Point> coords = new List<Point>();

        public Color colore = Color.FromArgb(20, 200, 50);
        public Direction direction = Direction.UP;

        public SnakeData()
        {
            for (int i = 0; i < lunghezzaIniziale; i++)
            {
                coords.Add(new Point(100, 100 + 15 * i));
            }
        }
    }
}
