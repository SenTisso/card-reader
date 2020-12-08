using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace card_reader.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseCardPage : ContentPage
    {
        public ChooseCardPage()
        {
            InitializeComponent();
        }
        async void OnCardSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
            await Navigation.PushAsync(new NewCardPage { });
        }

        // takto se nastavi dynamicky barva toho toolbaru
        /*protected override async void OnAppearing()
        {
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Black;
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.OrangeRed;
        }*/
    }
}