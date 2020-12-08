using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace card_reader.Models
{
    public class SupportedCard
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public SupportedCard(int ID, string Name, string ImagePath) {
            this.ID = ID;
            this.Name = Name;
            this.ImagePath = ImagePath;
        }

        public static ObservableCollection<SupportedCard> getSupportedCards()
        {
            ObservableCollection<SupportedCard> SupportedCards = new ObservableCollection<SupportedCard>
            {
                new SupportedCard(0, "Billa", "billa.png"),
                new SupportedCard(1, "Tesco", "tesco.png"),
                new SupportedCard(2, "Penny", "penny.png"),
                new SupportedCard(3, "IKEA", "ikea.png")
            };

            return SupportedCards;
        }
    }
}
