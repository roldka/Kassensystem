using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem.ViewModel
{
    public class GesamtGegeben
    {
        public GesamtGegeben()
        {
            Gegeben = GlobaleVariablen.Gegeben;
            Rückgeld = GlobaleVariablen.Rückgeld;
        }

        public float Gegeben { get; private set; }
        public float Rückgeld { get; private set; }

        public void GesamtGegebenErhöhen(float erhöhung)
        {
            if(GlobaleVariablen.tmp < 1)
            {
                GlobaleVariablen.Gegeben += erhöhung;
                Gegeben = GlobaleVariablen.Gegeben;
            }
            else
            {
                GlobaleVariablen.Gegeben = erhöhung;
                Gegeben = GlobaleVariablen.Gegeben;
            }
        }
        public void RückgeldBerechnen()
        {
            GlobaleVariablen.Rückgeld = GlobaleVariablen.Gegeben - GlobaleVariablen.AktuellerPreis;
        }
    }
}
