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
    public partial class Game : Window
    {
        public Game()
        {
            InitializeComponent();
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
                    }
                }
            }
            e.Handled = true;
        }
        
        private void B00_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }
        private void B00_RightClick(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B01_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B01_RightClick(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B02_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B02_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B03_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B03_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B04_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B04_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B05_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B05_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B06_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B06_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B07_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B07_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B08_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B08_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B10_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B10_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B11_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B11_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B12_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B12_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B13_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B13_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B14_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B14_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B15_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B15_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B16_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B16_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B17_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B17_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B18_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B18_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B20_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B20_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B21_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B21_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B22_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B22_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B23_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B23_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B24_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B24_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B25_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B25_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B26_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B26_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B27_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B27_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B28_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B28_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B30_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B30_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B31_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B31_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B32_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B32_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B33_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B33_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B34_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B34_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B35_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B35_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B36_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B36_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B37_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B37_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B38_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B38_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B40_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B40_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B41_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B41_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B42_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B42_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B43_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B43_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B44_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B44_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B45_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B45_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B46_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B46_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B47_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B47_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B48_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B48_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B50_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B50_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B51_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B51_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B52_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B52_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B53_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B53_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B54_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B54_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B55_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B55_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B56_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B56_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B57_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B57_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B58_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B58_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B60_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B60_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B61_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B61_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B62_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B62_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B63_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B63_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B64_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B64_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B65_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B65_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B66_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B66_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B67_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B67_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B68_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B68_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B70_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B70_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B71_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B71_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B72_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B72_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B73_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B73_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B74_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B74_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B75_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B75_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B76_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B76_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B77_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B77_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B78_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B78_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B80_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B80_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B81_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B81_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B82_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B82_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B83_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B83_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B84_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B84_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B85_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B85_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B86_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B86_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B87_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B87_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }

        private void B88_Click(object sender, RoutedEventArgs e)
        {
            RevealTile(sender, e);
        }

        private void B88_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FlagTile(sender, e);
        }
    }
}
