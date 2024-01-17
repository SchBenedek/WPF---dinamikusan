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

namespace WPF___dinamikusan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void naptar_Click(object sender, RoutedEventArgs e)
        {
            Naptae naptae = new Naptae();

            naptae.Show();
        }

        private void masodik_feladat_Click(object sender, RoutedEventArgs e)
        {
            masodik masik = new masodik();
            masik.Show();
        }
    }
}
