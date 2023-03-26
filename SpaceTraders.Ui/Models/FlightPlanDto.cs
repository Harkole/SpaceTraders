namespace SpaceTraders.Ui.Models
{
    public class FlightPlanDto
    {
        public DateTime ArrivesAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public string? Departure { get; set; }

        public string? Destination { get; set; }

        public int Distance { get; set; }

        public int FuelConsumed { get; set; }

        public int FuelRemaining { get; set; }

        public string? Id { get; set; }

        public string? ShipId { get; set; }

        public string? TerminatedAt { get; set; }

        public int TimeRemainingInSeconds { get; set; }
    }
}
