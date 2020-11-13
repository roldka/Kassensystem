using System;
using System.Collections.Generic;
using System.Windows.Markup;
using Kassensystem.ViewModel;

namespace Kassensystem.Model
{
    public class KassensystemManager
    {
        private GesamtPreis _gesamtPreis;
        private GesamtGewicht _gesamtGewicht;
        private GesamtGegeben _gesamtGegeben;
        public KassensystemManager()
        {
            _gesamtPreis = new GesamtPreis();
            _gesamtGewicht = new GesamtGewicht();
            _gesamtGegeben = new GesamtGegeben();
        }

        public GesamtPreis GesamtPreisErhöhen(float erhöhung)
        {
            _gesamtPreis.GesamtPreisErhöhen(erhöhung);
            return _gesamtPreis;
        }
        public GesamtGewicht GesamtGewichtErhöhen(float erhöhung)
        {
            _gesamtGewicht.GesamtGewichtErhöhen(erhöhung);
            return _gesamtGewicht;
        }
        public GesamtGegeben GesamtGegebenErhöhen(float erhöhung)
        {
            _gesamtGegeben.GesamtGegebenErhöhen(erhöhung);
            return _gesamtGegeben;
        }
        public GesamtGegeben RückgeldBerechnen()
        {
            _gesamtGegeben.RückgeldBerechnen();
            return _gesamtGegeben;
        }
        public float GewichtAusrechnen(float preis)
        {
            return preis * GlobaleVariablen.Gewicht;
        }
    }
}