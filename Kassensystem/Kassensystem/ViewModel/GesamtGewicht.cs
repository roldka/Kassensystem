using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem.ViewModel
{
    public class GesamtGewicht
    {
        public GesamtGewicht()
        {
            Gewicht = GlobaleVariablen.Gewicht;             //Initialisierung
        }

        public float Gewicht { get; private set; }          //Deklaration

        public void GesamtGewichtErhöhen(float erhöhung)
        {
            // Addition der Nachkommazahl
            if (GlobaleVariablen.tmp < 1)
            {
                GlobaleVariablen.Gewicht += erhöhung;
                Gewicht = GlobaleVariablen.Gewicht;
            }
            else
            {
                //Setzung der Vorkommazahl
                GlobaleVariablen.Gewicht = erhöhung;
                Gewicht = GlobaleVariablen.Gewicht;
            }
        }
    }
}
