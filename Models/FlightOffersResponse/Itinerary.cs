namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Represents the itinerary, including flight segments and duration.
    /// </summary>
    public class Itinerary
    {
        /// <summary>
        /// Total duration of the itinerary.
        /// </summary>
        public string duration { get; set; }

        /// <summary>
        /// Array of flight segments that make up the itinerary.
        /// </summary>
        public Segment[] segments { get; set; }
    }
}
