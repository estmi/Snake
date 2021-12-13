using System.Drawing;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Snake2
{
    class SnakeGame
    {
        public enum DireccioSnake { Amunt, Dreta, Avall, Esquerra }
        public const int X_SIZE = 5;
        public const int Y_SIZE = 5;

        public Point CapSerp { get; set; } = new(X_SIZE / 2, Y_SIZE / 2);

        public Point CapSerp2 { get; set; } = new(X_SIZE / 2, Y_SIZE / 2 - 1);
        public Ellipse ellipse = new()
        {
            Fill = Brushes.Green
        };
        public Ellipse ellipse2 = new()
        {
            Fill = Brushes.Pink
        };

        public DireccioSnake Direccio { get; set; } = DireccioSnake.Avall;
        public DireccioSnake Direccio2 { get; set; } = DireccioSnake.Avall;

        public void Moure()
        {
            switch (Direccio)
            {
                case DireccioSnake.Avall:
                    CapSerp = new(CapSerp.X, CapSerp.Y + 1);
                    break;
                case DireccioSnake.Amunt:
                    CapSerp = new(CapSerp.X, CapSerp.Y - 1);
                    break;
                case DireccioSnake.Esquerra:
                    CapSerp = new(CapSerp.X - 1, CapSerp.Y);
                    break;
                case DireccioSnake.Dreta:
                    CapSerp = new(CapSerp.X + 1, CapSerp.Y);
                    break;

            }
            switch (Direccio2)
            {
                case DireccioSnake.Avall:
                    CapSerp2 = new(CapSerp2.X, CapSerp2.Y + 1);
                    break;
                case DireccioSnake.Amunt:
                    CapSerp2 = new(CapSerp2.X, CapSerp2.Y - 1);
                    break;
                case DireccioSnake.Esquerra:
                    CapSerp2 = new(CapSerp2.X - 1, CapSerp2.Y);
                    break;
                case DireccioSnake.Dreta:
                    CapSerp2 = new(CapSerp2.X + 1, CapSerp2.Y);
                    break;

            }
        }
    }
}
