using System.Text.Json.Serialization;

namespace SpaceTraders.Ui.Models
{
    public class CargoDto
    {
        [JsonPropertyName("good")]
        public string Symbol { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public int TotalVolume{ get; set; }
    }
}
