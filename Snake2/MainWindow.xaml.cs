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
using System.Windows.Threading;

namespace Snake2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SnakeGame jocSerp = new SnakeGame();
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int tamanyXCasella = (int)(canvas.ActualWidth / SnakeGame.X_SIZE);
            int tamanyYCasella = (int)(canvas.ActualHeight / SnakeGame.Y_SIZE);

            //Redibuixar cada vegada.
            Ellipse ellSerp = new Ellipse()
            {
                Fill = Brushes.Pink,
                Width = tamanyXCasella,
                Height = tamanyYCasella,
            };
            canvas.Children.Add(ellSerp);
            Canvas.SetTop(ellSerp, jocSerp.CapSerp.Y * tamanyYCasella );
            Canvas.SetLeft(ellSerp, jocSerp.CapSerp.X * tamanyXCasella );
        }

        private void canvas_KeyDown(object sender, KeyEventArgs e)
        {
            jocSerp.moure();
        }
    }
}
