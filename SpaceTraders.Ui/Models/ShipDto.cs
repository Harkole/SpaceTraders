namespace SpaceTraders.Ui.Models
{
    public class ShipDto
    {
        public IEnumerable<CargoDto>? Cargo { get; set; }

        public string Class { get; set; } = string.Empty;

        public string? FlightPlanId { get; set; }

        public string Id { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public string Manufacturer { get; set; } = string.Empty;

        public int MaxCargo { get; set; }

        public int Plating { get; set; }

        public int SpaceAvailable { get; set; }

        public int Speed { get; set; }

        public string Type { get; set; } = string.Empty;

        public int Weapons { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
