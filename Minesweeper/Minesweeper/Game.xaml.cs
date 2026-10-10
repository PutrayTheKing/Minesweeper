using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    public partial class Game : Window
    {
        Sweeper sweeper;
        public Game()
        {
            InitializeComponent();
            sweeper = new Sweeper();

            sweeper.CreateMines();
            sweeper.CreateTopography();
            sweeper.GenerateFields();
        }

        (int,int) SenderPos(object send)
        {
            int posY = 0;
            int posX = 0;

            if (send is Button button && button.Tag is string tagString)
            {

                string[] pos = tagString.Split(',');
                posY = int.Parse(pos[0]);
                posX = int.Parse(pos[1]);
            }

            return (posY, posX);
        }

        private void RevealTile(object sender, RoutedEventArgs e)
        {
            if (sender is Button clickedButton &&
                clickedButton.Template.FindName("TileImage", clickedButton) is Image image)
            {
                string currentSource = image.Source?.ToString() ?? "";

                if (currentSource.Contains("FlaggedTile.jpg"))
                {
                    return;
                }
                else
                {
                    image.Source = new BitmapImage(
                    new Uri("pack://application:,,,/Images/RevealedTile.jpg", UriKind.Absolute));
                }

                var (y, x) = SenderPos(sender);
                sweeper.FieldMatrix[y,x].IsRevealed = true;

                e.Handled = true;
            }
        }

        private int flaggedtiles = 0;

        private void FlagTile(object sender, RoutedEventArgs e)
        {
            if (sender is Button clickedButton &&
                clickedButton.Template.FindName("TileImage", clickedButton) is Image image)
            {
                string currentSource = image.Source?.ToString() ?? "";
                if (currentSource.Contains("RevealedTile.jpg"))
                {
                    return;
                }
                if (currentSource.Contains("FlaggedTile.jpg"))
                {
                    image.Source = new BitmapImage(
                    new Uri("pack://application:,,,/Images/UnexploredTile.jpg", UriKind.Absolute));
                    flaggedtiles -= 1;

                    var (y, x) = SenderPos(sender);
                    sweeper.FieldMatrix[y, x].IsFlagged = false;
                }
                else
                {
                    if (flaggedtiles >= 10)
                    {
                        return;
                    }
                    else
                    {
                        image.Source = new BitmapImage(
                        new Uri("pack://application:,,,/Images/FlaggedTile.jpg", UriKind.Absolute));
                        flaggedtiles += 1;

                        var (y, x) = SenderPos(sender);
                        sweeper.FieldMatrix[y, x].IsFlagged = true;
                    }
                }
            }
            e.Handled = true;
        }
        
    }
}
