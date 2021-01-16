using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using card_reader.Models;
using card_reader.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace card_reader.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardDetailPage : ContentPage
    {
        public CardDetailPage(Card Card)
        {
            InitializeComponent();

            // kartu preda CardDetailViewModel, kde se nastavi promenny a ten ViewModel se da jako BindingContext
            this.BindingContext = new CardDetailViewModel(Card);
        }
    }
}