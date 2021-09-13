using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ViewModel = new MainPageViewModel( pageService);
            InitializeComponent();
        }

        
    }
}
