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

            MainPage = new NewCardPage(); // TODO: kdyztak sem pokazdy mrdnouy treba tu stranku, na ktery se zrovna pracuje, jakoze aby se rovnou nacetla idk
            // TODO: jinak hlavni stranka bude CardList
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
