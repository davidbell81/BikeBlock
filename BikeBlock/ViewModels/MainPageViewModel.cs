using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using BikeBlock.models;
using BikeBlock.Persistence;
using BikeBlock.views;
using Xamarin.Forms;

namespace BikeBlock.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private IPageService _pageService;
        private IWalletStore _walletStore;

        public Wallet SelectedWallet { get; set; }

        private ObservableCollection<Wallet> _wallets;
        public ObservableCollection<Wallet> Wallets
        {
            get
            {
                return _wallets;
            }
            set
            {
                SetValue(ref _wallets, value);


            }
        }
        public ICommand NewWalletCommand { get; private set; }
        public ICommand LoadWalletsCommand { get; private set; }

        public MainPageViewModel( IPageService pageService, IWalletStore walletStore)
        {
            _pageService = pageService;
            _walletStore = walletStore;
           
            NewWalletCommand = new Command(async () => await pushWalletCreationPage());
            LoadWalletsCommand = new Command(async () => await LoadWallets());
        }

        public async Task LoadWallets()
        {
             Wallets = new ObservableCollection<Wallet>(await _walletStore.GetWallets());
            Console.WriteLine(Wallets.Count);
        }

        private async Task pushWalletCreationPage()
        { 

            var viewModel = new WalletCreationViewModel( _pageService, _walletStore);
           
            await _pageService.PushAsync(new WalletCreationPage(viewModel));
           
        }
    }
}
