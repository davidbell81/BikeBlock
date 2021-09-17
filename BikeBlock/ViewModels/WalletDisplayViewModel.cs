using System;
using System.Threading.Tasks;
using System.Windows.Input;
using BikeBlock.models;
using System.IO;

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
    public class WalletDisplayViewModel : BaseViewModel
    {
        
        private IPageService _pageService;
        private IWalletStore _walletStore;

        public Wallet Wallet { get; set; } = new Wallet();
        //public ICommand BuildWalletCommand
        //{
        //    get;
        //    private set;
        //}

        public WalletDisplayViewModel(IPageService pageService, IWalletStore walletStore)
        {
            _pageService = pageService;
            _walletStore = walletStore;
           // BuildWalletCommand = new Command(async () => await buildWallet());
        }

       
    }
}
