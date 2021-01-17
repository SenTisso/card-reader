using System;
using System.Diagnostics;
using System.Windows.Input;
using card_reader.Models;
using card_reader.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using ZXing;

namespace card_reader.ViewModels
{
    public class CardDetailViewModel : BaseViewModel
    {
        public string Name { private set; get; }
        public string Number { private set; get; }
        public string Color { private set; get; }
        public string BarcodeContent { private set; get; }
        public BarcodeFormat BarcodeFormat { private set; get; }
        
        public CardDetailViewModel(Card card)
        {
            Title = "Big PP CardDetail";
            Name = card.Name;
            Number = card.Number;
            Color = card.Color;
            BarcodeFormat = card.BarcodeFormat;
            BarcodeContent = card.BarcodeContent;
        }
    }
}