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
    /// Interaction logic for masodik.xaml
    /// </summary>
    public partial class masodik : Window
    {
        public masodik()
        {
            InitializeComponent();

            int row = 5;
            int col = 5;

            for(int i = 0; i < row; i++)
            {
                masodGrid.RowDefinitions.Add(new RowDefinition());
            }
            for(int i = 0;i < col; i++)
            {
                masodGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            Random r=new Random();

            for (int i = 0;i<row ; i++)
            {
                for(int j = 0;j < col ; j++)
                {
                    Button btn=new Button();
                    btn.Click += Kattintas();
                    int anyaf=r.Next(1,2);
                    if(anyaf%2==0)
                    {
                        btn.Background = Brushes.Blue;
                    }
                    else
                    {
                        btn.Background = Brushes.Red;
                    }
                }
            }
        }

        private RoutedEventHandler Kattintas()
        {
            int row = 5; int col=5;

            for(int i = 0;i<row ; i++)
            {

            }
        }
    }
}
