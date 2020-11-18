using System;
using System.Windows.Input;
using Kassensystem.ViewModel;
using Kassensystem.Model;

namespace Kassensystem.Command
{
    public class Zahlenfeld : ICommand
    {
        public event EventHandler CanExecuteChanged;                        //Instanzerzeugung
        private readonly KassensystemViewModel _kassenSystem;
        private readonly KassensystemManager _manager;
        private readonly string _kilogramm;
        private float tmp;
        public Zahlenfeld(KassensystemViewModel kassenSystem, KassensystemManager manager, string kilogramm)
        {
            _kilogramm = kilogramm;                                        //Initialisierung
            _kassenSystem = kassenSystem;
            _manager = manager;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //Fall Zurücksetzen
            if(_kilogramm == "z")
            {
                GlobaleVariablen.Gewicht = 0;
                _kassenSystem.GetGesamtGewicht = _manager.GesamtGewichtErhöhen(tmp);
                _kassenSystem.GetGesamtGegeben = _manager.GesamtGegebenErhöhen(tmp);
                GlobaleVariablen.tmp = 1;
                GlobaleVariablen.tmp2 = 0;
                GlobaleVariablen.tmp3 = "";
                GlobaleVariablen.tmp4 = 0;
            }
            else if(_kilogramm == ".")
            {
                //Fall Komma wird gesetzt
                GlobaleVariablen.tmp = GlobaleVariablen.tmp * 0.1f;
            }
            else
            {
                //Falls Komma gesetzt Kommastelle wird ausgerechnet und mit eingegebener Zahl verrechnet, Bedingung: Es wurden noch keine 3 Zahlen nach dem Komma gesetzt
                //und Zahlenfeld == false -> im Waage Bildschirm
                if (GlobaleVariablen.tmp4 < 3 && GlobaleVariablen.Zahlenfeld == false)
                {
                    if (GlobaleVariablen.tmp < 1)
                    {
                        tmp = float.Parse(_kilogramm);
                        for (int i = 0; i < GlobaleVariablen.tmp2; i++)
                        {
                            GlobaleVariablen.tmp *= 0.1f;
                        }
                        tmp = tmp * GlobaleVariablen.tmp;
                        GlobaleVariablen.tmp2 = 1;
                        GlobaleVariablen.tmp4 += 1;
                    }
                    else
                    {
                        GlobaleVariablen.tmp3 = GlobaleVariablen.tmp3 + _kilogramm;
                        tmp = float.Parse(GlobaleVariablen.tmp3);
                    }
                    //Eingegebene Zahl wird verrechnet
                    _kassenSystem.GetGesamtGewicht = _manager.GesamtGewichtErhöhen(tmp);
                }
                //Gleich wie oben, Bedingung: es wurden noch keine 2 Zahlen hinter dem Komma gesetzt und Zahlenfeld == true -> im Geld wird gegeben Bildschirm
                else if (GlobaleVariablen.tmp4 < 2 && GlobaleVariablen.Zahlenfeld == true)
                {
                    if (GlobaleVariablen.tmp < 1)
                    {
                        tmp = float.Parse(_kilogramm);
                        for (int i = 0; i < GlobaleVariablen.tmp2; i++)
                        {
                            GlobaleVariablen.tmp *= 0.1f;
                        }
                        tmp = tmp * GlobaleVariablen.tmp;
                        GlobaleVariablen.tmp2 = 1;
                        GlobaleVariablen.tmp4 += 1;
                    }
                    else
                    {
                        GlobaleVariablen.tmp3 = GlobaleVariablen.tmp3 + _kilogramm;
                        tmp = float.Parse(GlobaleVariablen.tmp3);
                    }
                    //Eingegebene Zahl wird verrechnet
                    _kassenSystem.GetGesamtGegeben = _manager.GesamtGegebenErhöhen(tmp);
                    _kassenSystem.GetGesamtGegeben = _manager.RückgeldBerechnen();
                } 
            }
        }
    }
}
