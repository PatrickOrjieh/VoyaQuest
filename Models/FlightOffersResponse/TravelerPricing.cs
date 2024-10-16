namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Traveler-specific pricing details.
    /// </summary>
    public class TravelerPricing
    {
        /// <summary>
        /// The identifier for the traveler.
        /// </summary>
        public string travelerId { get; set; }

        /// <summary>
        /// The fare option selected by the traveler.
        /// </summary>
        public string fareOption { get; set; }

        /// <summary>
        /// The type of traveler (e.g., ADULT, CHILD).
        /// </summary>
        public string travelerType { get; set; }

        /// <summary>
        /// The pricing details for the traveler.
        /// </summary>
        public Price price { get; set; }

        /// <summary>
        /// Array of fare details by segment.
        /// </summary>
        public FareDetailsBySegment[] fareDetailsBySegment { get; set; }
    }
}
