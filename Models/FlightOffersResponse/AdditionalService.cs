namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Represents additional services included with the flight offer.
    /// </summary>
    public class AdditionalService
    {
        /// <summary>
        /// The amount charged for the additional service.
        /// </summary>
        public string amount { get; set; }

        /// <summary>
        /// The type of service provided (e.g., CHECKED_BAGS).
        /// </summary>
        public string type { get; set; }
    }
}
