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
using Engine.ViewModels;

namespace RPGGameUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gameSession;
        //Declare as private variable cuz we aren't using the above variable anywhere else
        public MainWindow()
        {
            InitializeComponent();

            _gameSession = new GameSession();

            DataContext = _gameSession;
            // Build-in value
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _gameSession.CurrentPlayer.ExperiencePoints += 10;

        }
    }

    // Extensiable markup language - XAML
}