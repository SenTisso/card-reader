using System;
using System.Windows.Input;
using card_reader.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace card_reader.ViewModels
{
    public class CardListViewModel : BaseViewModel
    {
        // TODO: takto se nastavuji custom properties u samotnych ViewModelu
        public string Roman { get; }


        public CardListViewModel()
        {
            Title = "Big PP CardList";
            Roman = "roman";
        }
    }
}