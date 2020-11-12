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
            Preis = GlobaleVariablen.AktuellerPreis;
        }

        public float Preis { get; private set; }

        public void GesamtPreisErhöhen(float erhöhung)
        {
            GlobaleVariablen.AktuellerPreis += erhöhung;
            Preis = GlobaleVariablen.AktuellerPreis;
        }
    }
}
