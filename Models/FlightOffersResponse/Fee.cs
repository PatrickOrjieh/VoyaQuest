namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Represents an additional fee for the flight offer.
    /// </summary>
    public class Fee
    {
        /// <summary>
        /// The amount of the fee.
        /// </summary>
        public string amount { get; set; }

        /// <summary>
        /// The type of fee (e.g., SUPPLIER, TICKETING).
        /// </summary>
        public string type { get; set; }
    }
}
