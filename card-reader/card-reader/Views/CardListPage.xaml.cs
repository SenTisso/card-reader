using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace card_reader.Views
{
    public partial class CardListPage : ContentPage
    {
        public CardListPage()
        {
            InitializeComponent();
        }

        async void OnAddCard(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewCardPage { });
        }
    }
}
