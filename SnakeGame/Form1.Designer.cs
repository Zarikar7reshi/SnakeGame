
namespace SnakeGame
{
    partial class Finestra
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPunteggio = new System.Windows.Forms.Panel();
            this.lblPunteggio = new System.Windows.Forms.Label();
            this.pnlCampo = new System.Windows.Forms.Panel();
            this.pbxCorpoSnake = new System.Windows.Forms.PictureBox();
            this.pbxCodaSnake = new System.Windows.Forms.PictureBox();
            this.pbxTestaSnake = new System.Windows.Forms.PictureBox();
            this.pnlPunteggio.SuspendLayout();
            this.pnlCampo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCorpoSnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCodaSnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTestaSnake)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPunteggio
            // 
            this.pnlPunteggio.BackColor = System.Drawing.Color.Transparent;
            this.pnlPunteggio.Controls.Add(this.lblPunteggio);
            this.pnlPunteggio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPunteggio.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPunteggio.Location = new System.Drawing.Point(0, 0);
            this.pnlPunteggio.Name = "pnlPunteggio";
            this.pnlPunteggio.Size = new System.Drawing.Size(800, 30);
            this.pnlPunteggio.TabIndex = 0;
            // 
            // lblPunteggio
            // 
            this.lblPunteggio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPunteggio.AutoSize = true;
            this.lblPunteggio.ForeColor = System.Drawing.Color.White;
            this.lblPunteggio.Location = new System.Drawing.Point(299, 2);
            this.lblPunteggio.Name = "lblPunteggio";
            this.lblPunteggio.Size = new System.Drawing.Size(140, 28);
            this.lblPunteggio.TabIndex = 1;
            this.lblPunteggio.Text = "Punteggio: 0";
            this.lblPunteggio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCampo
            // 
            this.pnlCampo.BackColor = System.Drawing.Color.Transparent;
            this.pnlCampo.Controls.Add(this.pbxCorpoSnake);
            this.pnlCampo.Controls.Add(this.pbxCodaSnake);
            this.pnlCampo.Controls.Add(this.pbxTestaSnake);
            this.pnlCampo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCampo.Location = new System.Drawing.Point(0, 30);
            this.pnlCampo.Name = "pnlCampo";
            this.pnlCampo.Size = new System.Drawing.Size(800, 430);
            this.pnlCampo.TabIndex = 1;
            // 
            // pbxCorpoSnake
            // 
            this.pbxCorpoSnake.BackColor = System.Drawing.Color.Transparent;
            this.pbxCorpoSnake.Location = new System.Drawing.Point(100, 115);
            this.pbxCorpoSnake.Name = "pbxCorpoSnake";
            this.pbxCorpoSnake.Size = new System.Drawing.Size(15, 15);
            this.pbxCorpoSnake.TabIndex = 2;
            this.pbxCorpoSnake.TabStop = false;
            // 
            // pbxCodaSnake
            // 
            this.pbxCodaSnake.BackColor = System.Drawing.Color.Transparent;
            this.pbxCodaSnake.Location = new System.Drawing.Point(100, 130);
            this.pbxCodaSnake.Name = "pbxCodaSnake";
            this.pbxCodaSnake.Size = new System.Drawing.Size(15, 15);
            this.pbxCodaSnake.TabIndex = 1;
            this.pbxCodaSnake.TabStop = false;
            // 
            // pbxTestaSnake
            // 
            this.pbxTestaSnake.BackColor = System.Drawing.Color.Transparent;
            this.pbxTestaSnake.Location = new System.Drawing.Point(100, 100);
            this.pbxTestaSnake.Name = "pbxTestaSnake";
            this.pbxTestaSnake.Size = new System.Drawing.Size(15, 15);
            this.pbxTestaSnake.TabIndex = 0;
            this.pbxTestaSnake.TabStop = false;
            // 
            // Finestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.pnlCampo);
            this.Controls.Add(this.pnlPunteggio);
            this.Name = "Finestra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Finestra_Load);
            this.pnlPunteggio.ResumeLayout(false);
            this.pnlPunteggio.PerformLayout();
            this.pnlCampo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCorpoSnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCodaSnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTestaSnake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCampo;
        public System.Windows.Forms.Label lblPunteggio;
        public System.Windows.Forms.Panel pnlPunteggio;
        private System.Windows.Forms.PictureBox pbxTestaSnake;
        private System.Windows.Forms.PictureBox pbxCorpoSnake;
        private System.Windows.Forms.PictureBox pbxCodaSnake;
    }
}

