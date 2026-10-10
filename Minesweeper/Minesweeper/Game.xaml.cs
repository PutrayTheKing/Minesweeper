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
            var (y, x) = SenderPos(sender);
            if (sender is Button clickedButton &&
                clickedButton.Template.FindName("TileImage", clickedButton) is Image image)
            {
                string currentSource = image.Source?.ToString() ?? "";

                if (currentSource.Contains("FlaggedTile.jpg"))
                {
                    return;
                }
                else if (sweeper.FieldMatrix[y, x].IsBomb)
                {
                    image.Source = new BitmapImage(
                    new Uri("pack://application:,,,/Images/ExplodedBomb.jpg", UriKind.Absolute));
                    MessageBox.Show("Vesztettél!", "Játék Vége!");
                    this.Close();
                }
                else
                {
                    switch (sweeper.FieldMatrix[y, x].BombsNearby)
                    {
                        case 1:
                            image.Source = new BitmapImage(
                            new Uri("pack://application:,,,/Images/OneBomb.jpg", UriKind.Absolute));
                            break;
                        case 2:
                            image.Source = new BitmapImage(
                            new Uri("pack://application:,,,/Images/TwoBomb.jpg", UriKind.Absolute));
                            break;
                        case 3:
                            image.Source = new BitmapImage(
                            new Uri("pack://application:,,,/Images/ThreeBomb.jpg", UriKind.Absolute));
                            break;
                        case 4:
                            image.Source = new BitmapImage(
                            new Uri("pack://application:,,,/Images/FourBomb.jpg", UriKind.Absolute));
                            break;
                        case 5:
                            image.Source = new BitmapImage(
                            new Uri("pack://application:,,,/Images/FiveBomb.jpg", UriKind.Absolute));
                            break;
                        case 6:
                            image.Source = new BitmapImage(
                            new Uri("pack://application:,,,/Images/SixBomb.jpg", UriKind.Absolute));
                            break;
                        case 7:
                            image.Source = new BitmapImage(
                            new Uri("pack://application:,,,/Images/SevenBomb.jpg", UriKind.Absolute));
                            break;
                        case 8:
                            image.Source = new BitmapImage(
                            new Uri("pack://application:,,,/Images/EightBomb.jpg", UriKind.Absolute));
                            break;
                        default:
                            image.Source = new BitmapImage(
                            new Uri("pack://application:,,,/Images/RevealedTile.jpg", UriKind.Absolute));
                            break;
                    }
                }
                sweeper.FieldMatrix[y,x].IsRevealed = true;

                e.Handled = true;
            }
        }

        private int flaggedtiles = 0;
        private int bombsFlagged = 0;

        private void FlagTile(object sender, RoutedEventArgs e)
        {
            var (y, x) = SenderPos(sender);
            if (sender is Button clickedButton &&
                clickedButton.Template.FindName("TileImage", clickedButton) is Image image)
            {
                string currentSource = image.Source?.ToString() ?? "";
                if (sweeper.FieldMatrix[y, x].IsRevealed == true)
                {
                    return;
                }
                if (currentSource.Contains("FlaggedTile.jpg"))
                {
                    image.Source = new BitmapImage(
                    new Uri("pack://application:,,,/Images/UnexploredTile.jpg", UriKind.Absolute));
                    flaggedtiles -= 1;
                    sweeper.FieldMatrix[y, x].IsFlagged = false;

                    if (sweeper.FieldMatrix[y, x].IsBomb)
                        bombsFlagged--;
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
                        sweeper.FieldMatrix[y, x].IsFlagged = true;

                        if (sweeper.FieldMatrix[y, x].IsBomb)
                            bombsFlagged++;

                        if (bombsFlagged == 10)
                        {
                            MessageBox.Show("Nyertél!", "Játék Vége!");
                            this.Close();
                        }
                    }
                }
            }
            e.Handled = true;
        }
        
    }
}
