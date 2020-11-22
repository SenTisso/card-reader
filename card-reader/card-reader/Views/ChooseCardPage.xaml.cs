using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace card_reader.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseCardPage : ContentPage
    {
        public ChooseCardPage()
        {
            InitializeComponent();
        }

        // takto se nastavi dynamicky barva toho toolbaru
        /*protected override async void OnAppearing()
        {
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Black;
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.OrangeRed;
        }*/
    }
}