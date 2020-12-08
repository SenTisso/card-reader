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
            Title = "Vyberte kartu";

            SupportedCards = SupportedCard.getSupportedCards();
        }
    }
}