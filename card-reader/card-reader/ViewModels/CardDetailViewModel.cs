using System;
using System.Windows.Input;
using card_reader.Models;
using card_reader.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace card_reader.ViewModels
{
    public class CardDetailViewModel : BaseViewModel
    {
        public Card Card { private set; get; }
        
        public CardDetailViewModel(Card card)
        {
            Title = "Big PP CardDetail";
            Card = card;
        }
    }
}