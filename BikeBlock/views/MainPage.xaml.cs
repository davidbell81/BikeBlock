using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeBlock.Persistence;
using BikeBlock.ViewModels;
using BikeBlock.views;
using Xamarin.Forms;

namespace BikeBlock.views
{
    public partial class MainPage : ContentPage
    {

        public MainPageViewModel ViewModel
        {
            get { return BindingContext as MainPageViewModel; }
            set { BindingContext = value; }
        }

        public MainPage()
        {
            
            var pageService = new PageService();
            var walletStore = new SQLiteWalletStore(DependencyService.Get<ISQLiteDb>());
            ViewModel = new MainPageViewModel( pageService , walletStore);
            
            InitializeComponent();
        }

        protected override void OnAppearing()
        {

            ViewModel.LoadWalletsCommand.Execute(null);


            base.OnAppearing();
        }
    }
}
