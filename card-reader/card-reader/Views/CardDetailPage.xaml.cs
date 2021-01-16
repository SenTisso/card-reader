using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using card_reader.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace card_reader.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardDetailPage : ContentPage
    {
        public CardDetailPage(CardDetailViewModel CardDetailViewModel = null)
        {
            InitializeComponent();

            if (CardDetailViewModel != null)
            {
                Debug.WriteLine("CARDDETAILVIEWMODEL");
                Debug.WriteLine(CardDetailViewModel.BarcodeContent);
                this.BindingContext = CardDetailViewModel;
            }
        }
    }
}