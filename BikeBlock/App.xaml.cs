using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BikeBlock.views;
using BikeBlock.ViewModels;

namespace BikeBlock
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }

    public static class ViewModelLocator
    {

        static MainPageViewModel meetingsVM;
        static PageService pageService = new PageService();
      
        public static MainPageViewModel MainPageViewModel
        => meetingsVM ?? (meetingsVM = new MainPageViewModel(pageService));

        



    }
}
