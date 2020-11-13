using System;
using System.Windows.Input;
using Kassensystem.ViewModel;
using Kassensystem.Model;

namespace Kassensystem.Command
{
    public class Button : ICommand
    {

        private readonly KassensystemViewModel _kassenSystem;
        private readonly KassensystemManager _manager;
        private readonly float _preis;
        private readonly bool _stück;
        private readonly string _name;
        public Button(KassensystemViewModel kassenSystem, KassensystemManager manager, float preis, bool stück, string name)
        {
            _stück = stück;
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
            if(_preis != 0)
            { 
                if (_stück == true)
                {
                    _kassenSystem.GetGesamtPreis = _manager.GesamtPreisErhöhen(_preis);
                    GlobaleVariablen.Einkaufsliste.Add(_name);
                    GlobaleVariablen.EinkaufslistePreis.Add(_preis);
                    GlobaleVariablen.Währung.Add("€");
                }
                else
                {
                    if(GlobaleVariablen.Gewicht > 0)
                    { 
                        _kassenSystem.GetGesamtPreis = _manager.GesamtPreisErhöhen(_manager.GewichtAusrechnen(_preis));
                        GlobaleVariablen.Einkaufsliste.Add(_name);
                        GlobaleVariablen.EinkaufslistePreis.Add(_manager.GewichtAusrechnen(_preis));
                        GlobaleVariablen.Währung.Add("€");
                        GlobaleVariablen.Gewicht = 0;
                    }
                } 
            }
            else
            {
                _kassenSystem.GetGesamtPreis = _manager.GesamtPreisErhöhen(-GlobaleVariablen.AktuellerPreis);
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}