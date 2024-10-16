namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Represents a single flight segment within an itinerary.
    /// </summary>
    public class Segment
    {
        /// <summary>
        /// Departure details like airport, terminal, and time.
        /// </summary>
        public Departure departure { get; set; }

        /// <summary>
        /// Arrival details like airport, terminal, and time.
        /// </summary>
        public Arrival arrival { get; set; }

        /// <summary>
        /// The airline carrier code.
        /// </summary>
        public string carrierCode { get; set; }

        /// <summary>
        /// The flight number.
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// Aircraft information for the segment.
        /// </summary>
        public Aircraft aircraft { get; set; }

        /// <summary>
        /// Operating carrier information.
        /// </summary>
        public Operating operating { get; set; }

        /// <summary>
        /// Duration of the flight segment.
        /// </summary>
        public string duration { get; set; }

        /// <summary>
        /// Unique identifier for the segment.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Number of stops for the segment.
        /// </summary>
        public int numberOfStops { get; set; }

        /// <summary>
        /// Indicates if the carrier is blacklisted in the EU.
        /// </summary>
        public bool blacklistedInEU { get; set; }
    }
}
