using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Minesweeper.Sweeper;

namespace Minesweeper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Sweeper sweeper = new Sweeper();

            sweeper.CreateMines();
            sweeper.CreateTopography();
            sweeper.GenerateFields();
        }

        private Game game;

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            game?.Close();
            game = new Game();
            game.Show();
        }
    }
}