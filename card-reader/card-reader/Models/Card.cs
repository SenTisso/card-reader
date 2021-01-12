using SQLite;
using ZXing;

namespace card_reader.Models
{
    public class Card
    {
        [PrimaryKey, AutoIncrement]
        public int? ID { get; set; }
        public string Name { get; set; }
        public string BarcodeContent { get; set; }
        public BarcodeFormat BarcodeFormat { get; set; }
    }
}