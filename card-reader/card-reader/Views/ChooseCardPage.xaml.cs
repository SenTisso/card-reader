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
        static Random rnd = new Random();
        private string CardColor;
        private new List<string> Colors = new List<String>() { "#ffcdd2", "#f8bbd0", "#e1bee7", "#d1c4e9", "#c5cae9", "#bbdefb", "#b3e5fc", "#b2ebf2", "#b2dfdb", "#c8e6c9", "#dcedc8", "#f0f4c3", "#fff9c4", "#ffecb3", "#ffe0b2", "#ffccbc", "#d7ccc8", "#cfd8dc" };

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
        async void OnNextClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CameraPage (cardName.Text, this.CardColor));
        }

        async void OnTextChanged(object sender, EventArgs e)
        {
            if (cardName.Text.Length > 0)
            {
                cardCapital.Text = cardName.Text[0].ToString();
            } else
            {
                cardCapital.Text = "";
            }
            
            int r = rnd.Next(Colors.Count);
            this.CardColor = Colors[r];
            boxColor.Color = Color.FromHex(this.CardColor);
        }
    }
}