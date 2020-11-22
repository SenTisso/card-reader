using System;
using System.Collections.Generic;
using System.Text;

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

    }
}
