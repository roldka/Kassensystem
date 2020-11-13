using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem.ViewModel
{
    public static class GlobaleVariablen
    {
        public static float AktuellerPreis = 0;
        public static float Gewicht = 0;
        public static string GewichtString = "";
        public static float tmp = 1;
        public static float tmp2 = 0;
        public static string tmp3 = "";
        public static int tmp4 = 0;
        public static float Gegeben = 0;
        public static float Rückgeld = 0;
        public static bool Zahlenfeld;
        public static ObservableCollection<string> Einkaufsliste { get; set; } = new ObservableCollection<string>();
        public static ObservableCollection<float> EinkaufslistePreis { get; set; } = new ObservableCollection<float>();
        public static ObservableCollection<string> Währung { get; set; } = new ObservableCollection<string>();
    }
}
