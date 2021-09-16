using System;
using System.Threading.Tasks;
using System.Windows.Input;
using BikeBlock.models;
using CardanoSharp.Wallet;
using CardanoSharp.Wallet.Enums;
using CardanoSharp.Wallet.Models.Keys;
using CardanoSharp.Wallet.Extensions.Models;
using CardanoSharp.Wallet.Models;
using CardanoSharp.Wallet.Models.Derivations;
using CardanoSharp.Wallet.Models.Transactions;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Text.Json;
using BikeBlock.views;
using Xamarin.Forms;
using BikeBlock.Persistence;

namespace BikeBlock.ViewModels
{
    public class WalletCreationViewModel : BaseViewModel
    {
        private IPageService _pageService;
        private IWalletStore _walletStore;

        public Wallet Wallet { get; set; } = new Wallet();
        public ICommand BuildWalletCommand
        {
            get;
            private set;
        }

        public WalletCreationViewModel(IPageService pageService, IWalletStore walletStore)
        {
            _pageService = pageService;
            _walletStore = walletStore;
            BuildWalletCommand = new Command(async () => await buildWallet());
        }

        private async Task buildWallet()
        {
            var keyService = new KeyService();
            int size = 24;
            Mnemonic mnemonic = keyService.Generate(size, WordLists.English);
            Wallet.Mnemonic = mnemonic;
            Wallet.MasterKey = mnemonic.GetRootKey();
            // Arrange
            var accountPath = WalletPath.Parse("m/1852'/1815'/0'");
            var paymentPath = WalletPath.Parse("0/1");
            var account = Wallet.MasterKey
               .Derive() // m
               .Derive(accountPath.Purpose)
               .Derive(accountPath.Coin)
               .Derive(accountPath.AccountIndex);

            account.SetPublicKey();
            // use the Spending Password to 2-Way encrypt the Private Key
            // and then store both the encrypted Private Key and the plain Public Key.
            var blob = new Tuple<PrivateKey, PublicKey>(account.PrivateKey.Encrypt(Wallet.Password), account.PublicKey);
            var store = JsonSerializer.Serialize(blob);
            Wallet.SecureKeyBlob = store;
            await _walletStore.AddWallet(Wallet);





            MnemonicDisplayViewModel viewModel = new MnemonicDisplayViewModel(_pageService, Wallet);
            await _pageService.PushAsync(new MnemonicDisplayPage(viewModel));

        }
        
    }
}
