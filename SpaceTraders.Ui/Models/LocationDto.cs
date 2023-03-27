namespace SpaceTraders.Ui.Models
{
    public class LocationDto
    {
        public string? Symbol { get; set; }

        public string? Type { get; set; }

        public string? Name { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public bool AllowsConstruction { get; set; }

        public IEnumerable<string> Traits { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string>? Messages { get; set; }
    }
}
