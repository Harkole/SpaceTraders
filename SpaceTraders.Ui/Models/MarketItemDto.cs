namespace SpaceTraders.Ui.Models
{
    public class MarketItemDto
    {
        public string Symbol { get; set; } = string.Empty;

        public int VolumePerUnit { get; set; }

        public int PricePerUnit { get; set; }

        public int Spread { get; set; }

        public int PurchasePricePerUnit { get; set; }

        public int SellPricePerUnit { get; set; }

        public int QuantityAvailable { get; set; }
    }
}
