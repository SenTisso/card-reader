using ZXing;

namespace card_reader.Models
{
    public class Card
    {
        
        public string BarcodeContent { get; set; }
        public BarcodeFormat BarcodeFormat { get; set; }
    }
}