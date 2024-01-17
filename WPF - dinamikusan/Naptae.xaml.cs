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
using System.Windows.Shapes;

namespace WPF___dinamikusan
{
    /// <summary>
    /// Interaction logic for Naptae.xaml
    /// </summary>
    public partial class Naptae : Window
    {
        public Naptae()
        {
            InitializeComponent();
            int rows = 6; int cols = 4;
            int utolsonyitott = 0;
            naptargrid.Margin = new Thickness(10);

            for (int i = 0; i < rows; i++)
            {
                naptargrid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < cols; i++)
            {
                naptargrid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            int buttonszam = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Button btn = new Button();
                    btn.Content = buttonszam;
                    Grid.SetColumn(btn, j);
                    Grid.SetRow(btn, i);
                    btn.Click += Kattintas();
                    naptargrid.Children.Add(btn);
                }
            }


        }

        private RoutedEventHandler Kattintas(object sender)
        {
            Button btn = sender;
            if (Convert.ToInt16(sender.Content) > 10)
            {

            }
        }
    
    }
}
