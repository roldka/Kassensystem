using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Kassensystem.Command;
using Kassensystem.ViewModel;

namespace Kassensystem.ViewModel
{
    public class GesamtPreis
    {
        public GesamtPreis()
        {
            Preis = GlobaleVariablen.AktuellerPreis;        //Initialisierung
        }

        public float Preis { get; private set; }            //Deklaration

        public void GesamtPreisErhöhen(float erhöhung)      //ausrechnung des Gesamtpreises
        {
            GlobaleVariablen.AktuellerPreis += erhöhung;
            Preis = GlobaleVariablen.AktuellerPreis;
        }
    }
}
