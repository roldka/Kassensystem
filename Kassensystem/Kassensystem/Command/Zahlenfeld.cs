using System;
using System.Windows.Input;
using Kassensystem.ViewModel;
using Kassensystem.Model;

namespace Kassensystem.Command
{
    public class Zahlenfeld : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private readonly KassensystemViewModel _kassenSystem;
        private readonly KassensystemManager _manager;
        private readonly string _kilogramm;
        public Zahlenfeld(KassensystemViewModel kassenSystem, KassensystemManager manager, string kilogramm)
        {
            _kilogramm = kilogramm;
            _kassenSystem = kassenSystem;
            _manager = manager;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(_kilogramm == "z")
            {
                GlobaleVariablen.Gewicht = 0;
            }
            else if(_kilogramm == ".")
            {
                GlobaleVariablen.tmp = GlobaleVariablen.tmp * 0.1f;
            }
            else
            {
                GlobaleVariablen.tmp2 = float.Parse(_kilogramm);
                if (GlobaleVariablen.tmp < 1)
                {
                    for(int i = 0; i < GlobaleVariablen.tmp3; i++)
                    {
                        GlobaleVariablen.tmp *= 0.1f;
                    }
                    GlobaleVariablen.tmp2 = GlobaleVariablen.tmp2 * GlobaleVariablen.tmp;
                    GlobaleVariablen.tmp3 += 1;
                }
                GlobaleVariablen.Gewicht += GlobaleVariablen.tmp2;
                _manager.GesamtGewichtErhöhen();
            }
        }
    }
}
