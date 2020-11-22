using System;
using System.Windows.Input;
using card_reader.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using card_reader.Models;
using System.Collections.ObjectModel;

namespace card_reader.ViewModels
{
    public class ChooseCardViewModel: BaseViewModel
    {
        public ObservableCollection<SupportedCard> SupportedCards { private set; get; }

        public ChooseCardViewModel()
        {
            SupportedCards = new ObservableCollection<SupportedCard>();

            setSupportedCards();
        }

        private void setSupportedCards()
        {
            SupportedCards.Add(new SupportedCard(0, "Billa", "billa.png"));
            SupportedCards.Add(new SupportedCard(1, "Tesco", "tesco.png"));
            SupportedCards.Add(new SupportedCard(2, "Penny", "penny.png"));
            SupportedCards.Add(new SupportedCard(3, "IKEA", "ikea.png"));
            /*SupportedCards.Add(new SupportedCard(4, "Billa", "billa.png"));
            SupportedCards.Add(new SupportedCard(5, "Tesco", "tesco.png"));
            SupportedCards.Add(new SupportedCard(6, "Penny", "penny.png"));
            SupportedCards.Add(new SupportedCard(7, "IKEA", "ikea.png"));
            SupportedCards.Add(new SupportedCard(8, "Billa", "billa.png"));
            SupportedCards.Add(new SupportedCard(9, "Tesco", "tesco.png"));
            SupportedCards.Add(new SupportedCard(10, "Penny", "penny.png"));
            SupportedCards.Add(new SupportedCard(11, "IKEA", "ikea.png"));
            SupportedCards.Add(new SupportedCard(12, "Billa", "billa.png"));
            SupportedCards.Add(new SupportedCard(13, "Tesco", "tesco.png"));
            SupportedCards.Add(new SupportedCard(14, "Penny", "penny.png"));
            SupportedCards.Add(new SupportedCard(15, "IKEA", "ikea.png"));
            SupportedCards.Add(new SupportedCard(16, "Billa", "billa.png"));
            SupportedCards.Add(new SupportedCard(17, "Tesco", "tesco.png"));
            SupportedCards.Add(new SupportedCard(18, "Penny", "penny.png"));
            SupportedCards.Add(new SupportedCard(19, "IKEA", "ikea.png"));*/
        }
    }
}