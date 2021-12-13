using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace Snake2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SnakeGame game = new();
        DispatcherTimer timer = new();

        public MainWindow()
        {

            InitializeComponent();
            int CasellaX = (int)canvas.ActualWidth / SnakeGame.X_SIZE;
            int CasellaY = (int)canvas.ActualHeight / SnakeGame.Y_SIZE;
            canvas.Children.Add(game.ellipse);
            canvas.Children.Add(game.ellipse2);
            game.ellipse.Width = CasellaX;
            game.ellipse.Height = CasellaY;
            game.ellipse2.Width = CasellaX;
            game.ellipse2.Height = CasellaY;
            timer.Interval = new(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int CasellaX = (int)canvas.ActualWidth / SnakeGame.X_SIZE;
            int CasellaY = (int)canvas.ActualHeight / SnakeGame.Y_SIZE;
            game.ellipse.Width = CasellaX;
            game.ellipse.Height = CasellaY;
            game.ellipse2.Width = CasellaX;
            game.ellipse2.Height = CasellaY;
            game.Moure();
            game.Direccio2 = game.Direccio;
            Canvas.SetTop(game.ellipse, CasellaY * game.CapSerp.Y);
            Canvas.SetLeft(game.ellipse, CasellaX * game.CapSerp.X);
            Canvas.SetTop(game.ellipse2, CasellaY * game.CapSerp2.Y);
            Canvas.SetLeft(game.ellipse2, CasellaX * game.CapSerp2.X);
        }

        private void canvas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    if (game.Direccio != SnakeGame.DireccioSnake.Avall)
                    {
                        game.Direccio2 = game.Direccio;
                        game.Direccio = SnakeGame.DireccioSnake.Amunt;
                    }

                    break;
                case Key.S:
                    if (game.Direccio != SnakeGame.DireccioSnake.Amunt)
                    {
                        game.Direccio = SnakeGame.DireccioSnake.Avall;
                    }
                    break;
                case Key.A:
                    if (game.Direccio != SnakeGame.DireccioSnake.Dreta)
                    {
                        game.Direccio = SnakeGame.DireccioSnake.Esquerra;
                    }
                    break;
                case Key.D:
                    if (game.Direccio != SnakeGame.DireccioSnake.Esquerra)
                    {
                        game.Direccio = SnakeGame.DireccioSnake.Dreta;
                    }
                    break;
            }
        }
    }
}
