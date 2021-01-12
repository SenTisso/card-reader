using System;
using System.IO;
using card_reader.Database;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using card_reader.Views;

namespace card_reader
{
    public partial class App : Application
    {
        static CardDatabase database;

        public static CardDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new CardDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Cards.db3"));
                }
                return database;
            }
        }
        
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
