using System.Configuration;
using System.Data;
using System.Windows;
using YouTubeViewer.WPF.ViewModels;

namespace YouTubeViewer.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new YouTubeViewersViewModel()
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
