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

namespace buildingPath
{
    public partial class MainWindow : Window
    {
        Person myPerson;

        public MainWindow()
        {
            InitializeComponent();
            myPerson = new Person("Willy", 22, 75, 100, true);
            Binding binding = new Binding("Age");
            binding.Source = myPerson;
            textBox2.SetBinding(TextBox.TextProperty, binding);
            textBox1.DataContext = myPerson;
            textBox3.DataContext = myPerson;
            textBox4.DataContext = myPerson;
            textBox5.DataContext = myPerson;
        }
      
        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            myPerson.Score = int.Parse(((TextBox)sender).Text);
            label2.Content = myPerson.Score;

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            myPerson.Name = ((TextBox)sender).Text;
            label1.Content = myPerson.Name;
        }
    }
}
