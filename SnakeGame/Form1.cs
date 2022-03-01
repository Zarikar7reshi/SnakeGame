using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Finestra : Form
    {
        internal bool IsPaused = false;

        Apple mela;
        Snake snake;
        Punteggio punteggio;
        Campo campo;
        Timer timer = new Timer();

        //KeyEventArgs p = new KeyEventArgs(Keys.P);
        //KeyEventArgs up = new KeyEventArgs(Keys.Up);
        //KeyEventArgs down = new KeyEventArgs(Keys.Down);
        //KeyEventArgs left = new KeyEventArgs(Keys.Left);
        //KeyEventArgs right = new KeyEventArgs(Keys.Right);
        //PictureBox paint = new PictureBox();
        //public PictureBox segmentoCorpo;

        public Finestra()
        {
            InitializeComponent();
        }

        private void Finestra_Load(object sender, EventArgs e)
        {

            punteggio = new Punteggio(lblPunteggio, pnlPunteggio);
            campo = new Campo(pnlCampo);
            snake = new Snake(pbxTestaSnake, pbxCorpoSnake, pbxCodaSnake);
            mela = new Apple();

            pnlCampo.Controls.Add(mela.immagine);
            //Controls.AddRange(snake.immagine.ToArray());

            timer.Interval = 200;
            timer.Tick += Timer_Tick;
            KeyDown += Finestra_KeyDown;

            StartPosition = FormStartPosition.CenterScreen;
            campo.SchermataIniziale();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!IsPaused)
            {
                Cancella();
                Aggiorna();
                Visualizza();
            }
        }

        private void Finestra_KeyDown(object sender, KeyEventArgs e)                    //quando viene premuto un tasto
        {
            Keys tastoPremuto = e.KeyCode;
            snake.GetDirection(tastoPremuto);
            if (tastoPremuto == Keys.P)
            {
                MettiInPausa();
            }
        }

        private void Cancella()
        {
            snake.Cancella();
            mela.Cancella();
        }

        private void Aggiorna()
        {
            snake.Muovi();
            mela.Muovi();
        }

        private void Visualizza()
        {
            snake.Visualizza();
            mela.Visualizza();
        }

        private void MettiInPausa()
        {
            if (IsPaused)
            {
                IsPaused = !IsPaused;
            }
        }

    }
}
