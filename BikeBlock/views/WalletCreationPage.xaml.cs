using System;
using System.Collections.Generic;

using Xamarin.Forms;
using BikeBlock.models;
using BikeBlock.ViewModels;

namespace BikeBlock.views
{
    public partial class WalletCreationPage : ContentPage
    {


        public WalletCreationViewModel ViewModel
        {
            get { return BindingContext as WalletCreationViewModel; }
            set { BindingContext = value; }
        }

        public WalletCreationPage(WalletCreationViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
            
        }

        
    }
}
