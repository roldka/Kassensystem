using System;
using System.Windows.Input;
using Kassensystem.ViewModel;
using Kassensystem.Model;

namespace Kassensystem.Command
{
    public class Button : ICommand
    {

        private readonly KassensystemViewModel _kassenSystem;                   //Instanzerzeugung
        private readonly KassensystemManager _manager;
        private readonly float _preis;
        private readonly bool _stück;
        private readonly string _name;
        public Button(KassensystemViewModel kassenSystem, KassensystemManager manager, float preis, bool stück, string name)
        {
            _stück = stück;                                                     //Initialisierung
            _preis = preis;
            _kassenSystem = kassenSystem;
            _manager = manager;
            _name = name;
        }
        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //Nur falls Preis größer 0, Produkte mit Gewicht werden nicht ohne eingegebenes Gewicht genommen
            if(_preis > 0)
            { 
                if (_stück == true) //Produkt mit Stückzahl ausgewählt?
                {
                    _kassenSystem.GetGesamtPreis = _manager.GesamtPreisErhöhen(_preis);         //Zu zahlender Preis wird erhöht
                    GlobaleVariablen.Einkaufsliste.Add(_name);                                  //Einkaufsliste wird aktuallisiert
                    GlobaleVariablen.EinkaufslistePreis.Add(_preis);
                    GlobaleVariablen.Währung.Add("€");
                }
                else
                {
                    if(GlobaleVariablen.Gewicht > 0)    //nur wenn Gewicht größer 0
                    { 
                        _kassenSystem.GetGesamtPreis = _manager.GesamtPreisErhöhen(_manager.GewichtAusrechnen(_preis));     //Zu zahlender Preis wird erhöht
                        GlobaleVariablen.Einkaufsliste.Add(_name);                                                          //Einkaufsliste wird aktuallisiert
                        GlobaleVariablen.EinkaufslistePreis.Add(_manager.GewichtAusrechnen(_preis));
                        GlobaleVariablen.Währung.Add("€");
                        GlobaleVariablen.Gewicht = 0;                                                                       //Gewicht wird zurückgesetzt
                    }
                } 
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}