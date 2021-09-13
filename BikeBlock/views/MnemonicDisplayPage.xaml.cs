using System;
using System.Collections.Generic;
using BikeBlock.ViewModels;
using Xamarin.Forms;

namespace BikeBlock.views
{
    public partial class MnemonicDisplayPage : ContentPage
    {

        public MnemonicDisplayViewModel ViewModel
        {
            get { return BindingContext as MnemonicDisplayViewModel; }
            set { BindingContext = value; }
        }

        public MnemonicDisplayPage(MnemonicDisplayViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
        }
    }
}
