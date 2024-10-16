namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Pricing options like fare type and baggage inclusion.
    /// </summary>
    public class PricingOptions
    {
        /// <summary>
        /// The fare types available for the offer (e.g., PUBLISHED, PRIVATE).
        /// </summary>
        public string[] fareType { get; set; }

        /// <summary>
        /// Indicates if only fares that include checked bags are shown.
        /// </summary>
        public bool includedCheckedBagsOnly { get; set; }
    }
}
