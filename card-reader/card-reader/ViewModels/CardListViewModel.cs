using System;
using System.Windows.Input;
using card_reader.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace card_reader.ViewModels
{
    public class CardListViewModel : BaseViewModel
    {
        public CardListViewModel()
        {
            Title = "Big PP CardList";
            Roman = "roman";
        }
        
        // TODO: takto se nastavuji custom properties u samotnych ViewModelu
        string roman = string.Empty;
        public string Roman
        {
            get { return roman; }
            set { SetProperty(ref roman, value); }
        }
    }
}