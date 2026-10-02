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

namespace Minesweeper
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        public Game()
        {
            InitializeComponent();
        }
        
        private void B00_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button clickedButton &&
                clickedButton.Template.FindName("TileImage", clickedButton) is Image image)
            {
                string currentSource = image.Source?.ToString() ?? "";
                if (currentSource.Contains("Flagged Tile.jpg"))
                {
                    return;
                }
                else
                {
                    image.Source = new BitmapImage(
                    new Uri(@"C:\School\Projekt Labor\Minesweeper\Minesweeper\bin\Debug\net8.0-windows\Revealed Tile.jpg", UriKind.Absolute)
                    );
                }
            }
        }

        private void B00_RightClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button clickedButton &&
                clickedButton.Template.FindName("TileImage", clickedButton) is Image image)
            {
                string currentSource = image.Source?.ToString() ?? "";
                if (currentSource.Contains("Flagged Tile.jpg"))
                {
                    image.Source = new BitmapImage(
                    new Uri(@"C:\School\Projekt Labor\Minesweeper\Minesweeper\bin\Debug\net8.0-windows\Unexplored Tile.jpg", UriKind.Absolute)
                    );
                }
                else
                {
                    image.Source = new BitmapImage(
                    new Uri(@"C:\School\Projekt Labor\Minesweeper\Minesweeper\bin\Debug\net8.0-windows\Flagged Tile.jpg", UriKind.Absolute)
                    );
                }
            }
            e.Handled = true;
        }
    }
}
