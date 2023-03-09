using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace naplo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> tantargyak = new List<string>() { "Matematika", "Irodalom", "Informatika", "Testnevelés", "Angol", "Történelem", "Földrajz", "Kémia", "Biológia" };


        }
        private void txtNev_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cboTantargy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void sliJegy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
