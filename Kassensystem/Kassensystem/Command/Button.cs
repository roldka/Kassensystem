using System;
using System.Windows.Input;
using Kassensystem.ViewModel;
using Kassensystem.Model;

namespace Kassensystem.Command
{
    public class Button : ICommand
    {
        private bool x = false;
        private float tmp = 0;
        private readonly KassensystemViewModel _kassenSystem;
        private readonly KassensystemManager _manager;
        private readonly float _preis;
        private readonly bool _stück;
        public Button(KassensystemViewModel kassenSystem, KassensystemManager manager, float preis, bool stück)
        {
            _stück = stück;
            _preis = preis;
            _kassenSystem = kassenSystem;
            _manager = manager;
            
        }
        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (_stück == true)
            {
                _kassenSystem.GetGesamtPreis = _manager.GesamtPreisErhöhen(_preis);
            }
            else
            {
                if (x == false)
                {
                    tmp = _preis;
                    x = true;
                }
                else
                {

                }
               
            } 
        }

        public event EventHandler CanExecuteChanged;
    }
}