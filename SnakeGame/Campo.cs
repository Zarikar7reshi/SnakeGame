using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class Campo : Finestra
    {
        public static CampoData data = new CampoData();
        static Panel _pnlCampo;
        
        public Campo() { }
        public Campo(Panel pnlCampo)
        {
            _pnlCampo = pnlCampo;
            data.Righe = _pnlCampo.Width / data.DimensioneCella;
            data.Colonne = _pnlCampo.Height / data.DimensioneCella;
            data.C = new int[data.Righe, data.Colonne];
        }

        internal void SchermataIniziale()
        {
            Scritta();
            Record();
            PremiUnTasto();
        }

        private void Scritta()
        {
        }

        private void Record()
        {
        }

        private void PremiUnTasto()
        {
        }
    }
}
