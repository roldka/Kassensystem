using Kassensystem.ViewModel;
using System.Windows;

namespace Kassensystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool ViewEnd = false;
        private bool ViewZurück = false;
        private bool ViewFertig = false;
        private bool InWaage = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void WaageButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new WaageView();
            InWaage = true;
            Storno.IsEnabled = false;
            Bezahlen.IsEnabled = false;
            Waage.IsEnabled = false;
            Zurück.IsEnabled = true;
            Bestätigen.IsEnabled = true;
            GlobaleVariablen.Zahlenfeld = false;
            GlobaleVariablen.tmp = 1;
            GlobaleVariablen.tmp2 = 0;
            GlobaleVariablen.tmp3 = "";
            GlobaleVariablen.tmp4 = 0;
        }
        private void HauptButton_Click(object sender, RoutedEventArgs e)
        {
            if(ViewZurück == false)
            {
                DataContext = new HauptView();
                ViewEnd = false;
                ViewZurück = false;
                ViewFertig = false;
                Storno.IsEnabled = true;
                Bezahlen.IsEnabled = true;
                Waage.IsEnabled = true;
                Zurück.IsEnabled = false;
                Bestätigen.IsEnabled = false;
            }
            else
            {
                DataContext = new GegebenView();
                GlobaleVariablen.Zahlenfeld = true;
                Storno.IsEnabled = false;
                Bezahlen.IsEnabled = false;
                Waage.IsEnabled = false;
                Zurück.IsEnabled = true;
                Bestätigen.IsEnabled = true;
                ViewZurück = false;
                ViewEnd = true;
                ViewFertig = false;
            }
        }
        private void BezahlenButton_Click(object sender, RoutedEventArgs e)
        {
            if(ViewEnd == false)
            {
                DataContext = new GegebenView();
                GlobaleVariablen.Zahlenfeld = true;
                GlobaleVariablen.tmp = 1;
                GlobaleVariablen.tmp2 = 0;
                GlobaleVariablen.tmp3 = "";
                GlobaleVariablen.tmp4 = 0;
                Storno.IsEnabled = false;
                Bezahlen.IsEnabled = false;
                Waage.IsEnabled = false;
                Zurück.IsEnabled = true;
                Bestätigen.IsEnabled = true;
                ViewEnd = true;
                ViewFertig = false;
            }
            else
            {
                DataContext = new GegebenView();
                GlobaleVariablen.Zahlenfeld = true;
                GlobaleVariablen.tmp = 1;
                GlobaleVariablen.tmp2 = 0;
                GlobaleVariablen.tmp3 = "";
                GlobaleVariablen.tmp4 = 0;
                Storno.IsEnabled = false;
                Bezahlen.IsEnabled = false;
                Waage.IsEnabled = false;
                Zurück.IsEnabled = true;
                Bestätigen.IsEnabled = true;
                ViewFertig = false;
            }
        }
        private void BestätigenButton_Click(object sender, RoutedEventArgs e)
        {
            if (ViewEnd == true)
            {
                DataContext = new EndView();
                ViewZurück = true;
                ViewFertig = true;
                ViewEnd = false;
                Storno.IsEnabled = false;
                Bezahlen.IsEnabled = false;
                Waage.IsEnabled = false;
                Zurück.IsEnabled = true;
                Bestätigen.IsEnabled = true;
            }
            else if (ViewFertig == true)
            {
                DataContext = new HauptView();
                ViewEnd = false;
                ViewZurück = false;
                ViewFertig = false;
                Storno.IsEnabled = true;
                Bezahlen.IsEnabled = true;
                Waage.IsEnabled = true;
                Zurück.IsEnabled = false;
                Bestätigen.IsEnabled = false;
                GlobaleVariablen.AktuellerPreis = 0;
                GlobaleVariablen.Gewicht = 0;
                GlobaleVariablen.GewichtString = "";
                GlobaleVariablen.tmp = 1;
                GlobaleVariablen.tmp2 = 0;
                GlobaleVariablen.tmp3 = "";
                GlobaleVariablen.tmp4 = 0;
                GlobaleVariablen.Gegeben = 0;
                GlobaleVariablen.Rückgeld = 0;
                GlobaleVariablen.Einkaufsliste.Clear();
                GlobaleVariablen.EinkaufslistePreis.Clear();
                GlobaleVariablen.Währung.Clear();
            }
            else if(InWaage == true)
            {
                DataContext = new HauptView();
                InWaage = false;
                Storno.IsEnabled = true;
                Bezahlen.IsEnabled = true;
                Waage.IsEnabled = true;
                Zurück.IsEnabled = false;
                Bestätigen.IsEnabled = false;
            }
        }
        private void StornoButton_Click(object sender, RoutedEventArgs e)
        {
            GlobaleVariablen.AktuellerPreis = 0;
            GlobaleVariablen.Gewicht = 0;
            GlobaleVariablen.GewichtString = "";
            GlobaleVariablen.tmp = 1;
            GlobaleVariablen.tmp2 = 0;
            GlobaleVariablen.tmp3 = "";
            GlobaleVariablen.tmp4 = 0;
            GlobaleVariablen.Gegeben = 0;
            GlobaleVariablen.Rückgeld = 0;
            GlobaleVariablen.Einkaufsliste.Clear();
            GlobaleVariablen.EinkaufslistePreis.Clear();
            GlobaleVariablen.Währung.Clear();
            DataContext = new HauptView();
            ViewEnd = false;
            ViewZurück = false;
            ViewFertig = false;
            Storno.IsEnabled = true;
            Bezahlen.IsEnabled = true;
            Waage.IsEnabled = true;
            Zurück.IsEnabled = false;
            Bestätigen.IsEnabled = false;
        }
    }
}