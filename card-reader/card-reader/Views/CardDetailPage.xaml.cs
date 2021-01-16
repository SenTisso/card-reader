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
        private bool fromNewCardPage = false;
        
        public CardDetailPage(Card Card, bool fromNewCardPage = false)
        {
            InitializeComponent();

            this.fromNewCardPage = fromNewCardPage;

            // kartu preda CardDetailViewModel, kde se nastavi promenny a ten ViewModel se da jako BindingContext
            this.BindingContext = new CardDetailViewModel(Card);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            // pokud CardDetailPage byl volan z NewCard, tak odstran ty 2 stranky z navigace, aby sipka zpet v CardDetailPage sla rovnou na hlavni stranku
            if (this.fromNewCardPage)
            {
                /* je to touto metodou, jelikoz kdyz se to PopToRootAsync pri OnDisappearing, tak tam jeste problikne ta camera page */
                
                // odstrani predposledni page z navigace (mela by byt camera page)
                this.Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);
                
                // odstrani predposledni page z navigace (mela by byt input page)
                this.Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);
            }
        }
    }
}