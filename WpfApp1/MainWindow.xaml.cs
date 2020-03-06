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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid.SetColumn(firstLabel, Grid.GetColumn(firstLabel) % 2 == 0 ? 2 : 0);
            Grid.SetColumn(secondLabel, Grid.GetColumn(secondLabel) % 2);
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Grid.SetColumn(thirdLabel, 2);
            Grid.SetColumn(forthLabel, 0);
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Grid.SetColumn(thirdLabel, 0);
            Grid.SetColumn(forthLabel, 2);
        }
    }
}
