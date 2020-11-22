using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using card_reader.Views;

namespace card_reader
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CardListPage());
            // TODO: default stranka je CardList
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
}
