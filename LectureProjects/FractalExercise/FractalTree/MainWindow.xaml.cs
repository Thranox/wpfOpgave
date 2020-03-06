using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FractalTree
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

        private void DrawLine(Point p1, Point p2)
        {
            Line line = new Line();
            line.X1 = p1.X;
            line.X2 = p2.X;
            line.Y1 = p1.Y;
            line.Y2 = p2.Y;
            line.Stroke = Brushes.Black;
            line.StrokeThickness = 1;
            myCanvas.Children.Add(line);
        }

        private void DrawTree(double x0, double y0, double length, double angle)
        {
            Point p1 = new Point { X = x0, Y = y0 };
            Point p2 = new Point();
            p2.X = x0 + length * Math.Cos(Math.PI / 180 * angle);
            p2.Y = y0 + length * Math.Sin(Math.PI / 180 * angle);
            DrawLine(p1, p2);            
        }

        private void MainWindowLoaded(object sender, RoutedEventArgs e)
        {
            DrawTree(400, 400, 100, -90);
        }
    }
}
