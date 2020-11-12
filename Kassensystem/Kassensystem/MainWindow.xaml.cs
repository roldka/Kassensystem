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
        }
        private void HauptButton_Click(object sender, RoutedEventArgs e)
        {
            if(ViewZurück == false)
            {
                DataContext = new HauptView();
                ViewEnd = false;
                ViewZurück = false;
                ViewFertig = false;
            }
            else
            {
                DataContext = new GegebenView();
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
                ViewEnd = true;
                ViewFertig = false;
            }
            else
            {
                DataContext = new GegebenView();
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
            }
            else if (ViewFertig == true)
            {
                DataContext = new HauptView();
                ViewEnd = false;
                ViewZurück = false;
                ViewFertig = false;
            }
            else if(InWaage == true)
            {
                DataContext = new HauptView();
                InWaage = false;
                GlobaleVariablen.Gewicht = 0;
            }
        }
        private void StornoButton_Click(object sender, RoutedEventArgs e)
        {
            GlobaleVariablen.AktuellerPreis = 0;
            DataContext = new HauptView();
            ViewEnd = false;
            ViewZurück = false;
            ViewFertig = false;
        }
    }
}