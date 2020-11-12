using System;
using System.Collections.Generic;
using System.Windows.Markup;
using Kassensystem.ViewModel;

namespace Kassensystem.Model
{
    public class KassensystemManager
    {
        private int y = -1;
        private GesamtPreis _gesamtPreis;
        private GesamtGewicht _gesamtGewicht;
        public KassensystemManager()
        {
            _gesamtPreis = new GesamtPreis();
            _gesamtGewicht = new GesamtGewicht();
        }

        public GesamtPreis GesamtPreisErhöhen(float erhöhung)
        {
            _gesamtPreis.GesamtPreisErhöhen(erhöhung);
            return _gesamtPreis;
        }
        public GesamtGewicht GesamtGewichtErhöhen()
        {
            _gesamtGewicht.GesamtGewichtErhöhen();
            return _gesamtGewicht;
        }
    }
}