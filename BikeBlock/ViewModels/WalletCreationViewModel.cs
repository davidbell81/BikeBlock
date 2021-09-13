using System;
using System.Threading.Tasks;
using System.Windows.Input;
using BikeBlock.models;
using CardanoSharp.Wallet;
using CardanoSharp.Wallet.Enums;
using CardanoSharp.Wallet.Models.Keys;
using CardanoSharp.Wallet.Extensions.Models;
using BikeBlock.views;

namespace BikeBlock.ViewModels
{
    public class WalletCreationViewModel : BaseViewModel
    {
        private IPageService _pageService;

        public Wallet Wallet { get; set; } = new Wallet();
        public ICommand BuildWalletCommand
        {
            get;
            private set;
        }

        public WalletCreationViewModel(IPageService pageService)
        {
            _pageService = pageService;
        }

        private async Task buildAndDisplayMnemonic()
        {
            var keyService = new KeyService();
            int size = 24;
            Mnemonic mnemonic = keyService.Generate(size, WordLists.English);
            Wallet.Mnemonic = mnemonic;
            Wallet.MasterKey = mnemonic.GetRootKey();
            MnemonicDisplayViewModel viewModel = new MnemonicDisplayViewModel(_pageService, Wallet);
            await _pageService.PushAsync(new MnemonicDisplayPage(viewModel));

        }
        
    }
}
