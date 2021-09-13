using System;
using System.Threading.Tasks;
using System.Windows.Input;
using BikeBlock.views;
using Xamarin.Forms;

namespace BikeBlock.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private IPageService _pageService;

        public ICommand NewWalletCommand { get; private set; }


        public MainPageViewModel( IPageService pageService)
        {
            _pageService = pageService;
            NewWalletCommand = new Command(async () => await pushWalletCreationPage());
        }

        private async Task pushWalletCreationPage()
        { 

            var viewModel = new WalletCreationViewModel( _pageService);
            await _pageService.PushAsync(new WalletCreationPage(viewModel));
           
        }
    }
}
