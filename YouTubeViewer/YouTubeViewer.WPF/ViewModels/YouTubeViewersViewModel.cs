using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YouTubeViewer.WPF.ViewModels
{
    public class YouTubeViewersViewModel : ViewModelBase
    {
        public YouTubeViewersDetailsViewModel YouTubeViewersListingViewModel { get; }
        public YouTubeViewersDetailsViewModel YouTubeViewersDetailsViewModel { get; }
        public ICommand AddYouTubeViewersCommand { get; }

        public YouTubeViewersViewModel() 
        { 
            YouTubeViewersListingViewModel = new YouTubeViewersDetailsViewModel();
            YouTubeViewersDetailsViewModel = new YouTubeViewersDetailsViewModel();
        }
    }
}
