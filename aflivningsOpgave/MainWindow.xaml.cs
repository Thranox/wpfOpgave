
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace aflivningsOpgave
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = new List<User>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            StreamReader reader = null;
            var filePath = string.Empty;
            var fileContent = string.Empty;
            try
            {
                if (openFileDialog.ShowDialog() == true)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                    reader = new StreamReader(fileStream);
                    fileContent = reader.ReadToEnd();
                    foreach (string s in fileContent.Split(new[] { '\n' }))
                    {
                        User user = new User(s);
                        users.Add(user);
                    }
                    foreach (User user in users)
                    {
                        userContent.Items.Add(user);
                    }
                    timeLabel.Content = DateTime.Now;
                    numberOfUsers.Text += " " + users.Count;
                }
            }
            catch {
                Console.WriteLine( "Mistakes..");
            } 
            finally {
                Console.WriteLine("close all streams");
                reader.Close();
            }
        }

        private void userContent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            myGrid.DataContext = userContent.SelectedItem;
        }
    }

}
