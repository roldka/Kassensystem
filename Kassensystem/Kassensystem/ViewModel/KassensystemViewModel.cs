using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Kassensystem.Annotations;
using Kassensystem.Command;
using Kassensystem.Model;
using System.Collections.ObjectModel;

namespace Kassensystem.ViewModel
{
    public class KassensystemViewModel : INotifyPropertyChanged
    {
        private GesamtPreis _gesamtPreis;
        private GesamtGewicht _gesamtGewicht;
        private GesamtGegeben _gesamtGegeben;
        private KassensystemManager _manager;

        public KassensystemViewModel()
        {
            _manager = new KassensystemManager();

            Kopfsalat = new Button(this, _manager, 1.40f, true, "Kopfsalat");
            Eichblatt = new Button(this, _manager, 1.40f, true, "Eichblatt");
            Romana = new Button(this, _manager, 1.40f, true, "Romana");
            GemSalatkräuter = new Button(this, _manager, 1.80f, true, "GemSalatKräuter");
            Schnittlauch = new Button(this, _manager, 1.20f, true, "Schnittlauch");
            Dill = new Button(this, _manager, 1.20f, true, "Dill");
            Minze = new Button(this, _manager, 1.20f, true, "Minze");
            Rosmarin = new Button(this, _manager, 1.20f, true, "Rosmarin");
            Frühlingszwiebeln = new Button(this, _manager, 1.20f, true, "Frühlingszwiebeln");
            Steinchampignons = new Button(this, _manager, 11.00f, false, "Steinchampignons");
            Shiitake = new Button(this, _manager, 27.00f, false, "Shiitake");
            Avocado = new Button(this, _manager, 1.60f, true, "Avocado");
            Landgurken = new Button(this, _manager, 4.40f, false, "Landgurken");
            Auberginen = new Button(this, _manager, 3.60f, false, "Auberginen");
            Zucchini = new Button(this, _manager, 3.00f, false, "Zucchini");
            Paprika = new Button(this, _manager, 5.90f, false, "Paprika");
            Buschbohnen = new Button(this, _manager, 12.00f, false, "Buschbohnen");
            Tomaten = new Button(this, _manager, 4.60f, false, "Tomaten");
            Cocktailtomaten = new Button(this, _manager, 8.40f, false, "Cocktailtomaten");
            Blumenkohl = new Button(this, _manager, 3.20f, false, "Blumenkohl");
            Brokkoli = new Button(this, _manager, 5.00f, false, "Brokkoli");
            Lauch = new Button(this, _manager, 4.90f, false, "Lauch");
            Hokkaidokürbis = new Button(this, _manager, 2.10f, true, "Hokkaidokürbis");
            Kartoffeln = new Button(this, _manager, 1.80f, false, "Kartoffeln");
            Knoblauch = new Button(this, _manager, 14.00f, false, "Knoblauch");
            Erbsen = new Button(this, _manager, 5.00f, false, "Erbsen");
            Linsen = new Button(this, _manager, 5.00f, false, "Linsen");
            Apfel = new Button(this, _manager, 0.60f, true, "Apfel");
            Birne = new Button(this, _manager, 0.50f, true, "Birne");
            Bananen = new Button(this, _manager, 2.60f, false, "Bananen");
            Aprikosen = new Button(this, _manager, 7.00f, false, "Aprikosen");
            Kiwi = new Button(this, _manager, 0.30f, true, "Kiwi");
            Trauben = new Button(this, _manager, 12.00f, false, "Trauben");
            Erdbeeren = new Button(this, _manager, 4.90f, true, "Erdbeeren");
            Blaubeeren = new Button(this, _manager, 5.30f, true, "Blaubeeren");
            Himbeeren = new Button(this, _manager, 5.30f, true, "Himbeeren");
            Brombeeren = new Button(this, _manager, 5.30f, true, "Brombeeren");
            Stachelbeeren = new Button(this, _manager, 5.30f, true, "Stachelbeeren");
            Johannisbeeren = new Button(this, _manager, 5.30f, true, "Johannisbeeren");
            EiM = new Button(this, _manager, 0.40f, true, "Ei Größe M");
            Pasta = new Button(this, _manager, 0.80f, true, "Pasta");
            Reis = new Button(this, _manager, 2.20f, true, "Reis");
            Bauernbrot = new Button(this, _manager, 4.80f, true, "Bauernbrot");
            Konfitüre = new Button(this, _manager, 2.40f, true, "Konfitüre");
            Honig = new Button(this, _manager, 5.20f, true, "Honig");
            Wasser = new Button(this, _manager, 1.40f, true, "Wasser");
            Cola = new Button(this, _manager, 1.60f, true, "Cola");
            Fanta = new Button(this, _manager, 1.60f, true, "Fanta");
            Apfelschorle = new Button(this, _manager, 1.60f, true, "Apfelschorle");
            Toilettenpapier = new Button(this, _manager, 8.00f, true, "Toilettenpapier");

            Null = new Zahlenfeld(this, _manager, "0");
            Eins = new Zahlenfeld(this, _manager, "1");
            Zwei = new Zahlenfeld(this, _manager, "2");
            Drei = new Zahlenfeld(this, _manager, "3");
            Vier = new Zahlenfeld(this, _manager, "4");
            Fünf = new Zahlenfeld(this, _manager, "5");
            Sechs = new Zahlenfeld(this, _manager, "6");
            Sieben = new Zahlenfeld(this, _manager, "7");
            Acht = new Zahlenfeld(this, _manager, "8");
            Neun = new Zahlenfeld(this, _manager, "9");
            Komma = new Zahlenfeld(this, _manager, ".");
            Zurück = new Zahlenfeld(this, _manager, "z");

            GetGesamtGewicht = new GesamtGewicht();
            GetGesamtPreis = new GesamtPreis();
            GetGesamtGegeben = new GesamtGegeben();
        }

        public Button Kopfsalat { get; set; }
        public Button Eichblatt { get; set; }
        public Button Romana { get; set; }
        public Button GemSalatkräuter { get; set; }
        public Button Schnittlauch { get; set; }
        public Button Dill { get; set; }
        public Button Minze { get; set; }
        public Button Rosmarin { get; set; }
        public Button Frühlingszwiebeln { get; set; }
        public Button Steinchampignons { get; set; }
        public Button Shiitake { get; set; }
        public Button Avocado { get; set; }
        public Button Landgurken { get; set; }
        public Button Auberginen { get; set; }
        public Button Zucchini { get; set; }
        public Button Paprika { get; set; }
        public Button Buschbohnen { get; set; }
        public Button Tomaten { get; set; }
        public Button Cocktailtomaten { get; set; }
        public Button Blumenkohl { get; set; }
        public Button Brokkoli { get; set; }
        public Button Lauch { get; set; }
        public Button Hokkaidokürbis { get; set; }
        public Button Kartoffeln { get; set; }
        public Button Knoblauch { get; set; }
        public Button Erbsen { get; set; }
        public Button Linsen { get; set; }
        public Button Apfel { get; set; }
        public Button Birne { get; set; }
        public Button Bananen { get; set; }
        public Button Aprikosen { get; set; }
        public Button Kiwi { get; set; }
        public Button Trauben { get; set; }
        public Button Erdbeeren { get; set; }
        public Button Blaubeeren { get; set; }
        public Button Himbeeren { get; set; }
        public Button Brombeeren { get; set; }
        public Button Stachelbeeren { get; set; }
        public Button Johannisbeeren { get; set; }
        public Button EiM { get; set; }
        public Button Pasta { get; set; }
        public Button Reis { get; set; }
        public Button Bauernbrot { get; set; }
        public Button Konfitüre { get; set; }
        public Button Honig { get; set; }
        public Button Wasser { get; set; }
        public Button Cola { get; set; }
        public Button Fanta { get; set; }
        public Button Apfelschorle { get; set; }
        public Button Toilettenpapier { get; set; }

        public Zahlenfeld Null { get; set; }
        public Zahlenfeld Eins { get; set; }
        public Zahlenfeld Zwei { get; set; }
        public Zahlenfeld Drei { get; set; }
        public Zahlenfeld Vier { get; set; }
        public Zahlenfeld Fünf { get; set; }
        public Zahlenfeld Sechs { get; set; }
        public Zahlenfeld Sieben { get; set; }
        public Zahlenfeld Acht { get; set; }
        public Zahlenfeld Neun { get; set; }
        public Zahlenfeld Komma { get; set; }
        public Zahlenfeld Zurück { get; set; }
        
        public GesamtPreis GetGesamtPreis
        {
            get => _gesamtPreis;
            set
            {
                _gesamtPreis = value;
                OnPropertyChanged();
            }
        }

        public GesamtGewicht GetGesamtGewicht
        {
            get => _gesamtGewicht;
            set
            {
                _gesamtGewicht = value;
                OnPropertyChanged();
            }
        }

        public GesamtGegeben GetGesamtGegeben
        {
            get => _gesamtGegeben;
            set
            {
                _gesamtGegeben = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> GetEinkaufsliste
        {
            get => GlobaleVariablen.Einkaufsliste;
            set
            {
                GlobaleVariablen.Einkaufsliste = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<float> GetEinkaufslistePreis
        {
            get => GlobaleVariablen.EinkaufslistePreis;
            set
            {
                GlobaleVariablen.EinkaufslistePreis = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> GetWährung
        {
            get => GlobaleVariablen.Währung;
            set
            {
                GlobaleVariablen.Währung = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
