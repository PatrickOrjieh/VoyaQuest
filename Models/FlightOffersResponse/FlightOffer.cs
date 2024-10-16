namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Represents a flight offer with details like price, itineraries, and traveler pricing.
    /// </summary>
    public class FlightOffer
    {
        /// <summary>
        /// Unique identifier for the flight offer.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Source of the flight offer (e.g., GDS, LCC).
        /// </summary>
        public string source { get; set; }

        /// <summary>
        /// Indicates if instant ticketing is required.
        /// </summary>
        public bool instantTicketingRequired { get; set; }

        /// <summary>
        /// Indicates if the offer contains heterogeneous traveler types.
        /// </summary>
        public bool nonHomogeneous { get; set; }

        /// <summary>
        /// Indicates if the offer is for a one-way trip.
        /// </summary>
        public bool oneWay { get; set; }

        /// <summary>
        /// Indicates if the offer is an upsell offer.
        /// </summary>
        public bool isUpsellOffer { get; set; }

        /// <summary>
        /// The last date available for ticketing.
        /// </summary>
        public string lastTicketingDate { get; set; }

        /// <summary>
        /// The number of bookable seats available.
        /// </summary>
        public int numberOfBookableSeats { get; set; }

        /// <summary>
        /// List of itineraries associated with the flight offer.
        /// </summary>
        public Itinerary[] itineraries { get; set; }

        /// <summary>
        /// Price details for the flight offer.
        /// </summary>
        public Price price { get; set; }

        /// <summary>
        /// Pricing options such as included fare types and baggage options.
        /// </summary>
        public PricingOptions pricingOptions { get; set; }

        /// <summary>
        /// List of validating airline codes.
        /// </summary>
        public string[] validatingAirlineCodes { get; set; }

        /// <summary>
        /// Traveler-specific pricing details.
        /// </summary>
        public TravelerPricing[] travelerPricings { get; set; }
    }
}
