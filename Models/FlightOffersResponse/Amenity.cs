namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Represents an amenity provided during the flight.
    /// </summary>
    public class Amenity
    {
        /// <summary>
        /// Description of the amenity.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Indicates if the amenity is chargeable.
        /// </summary>
        public bool isChargeable { get; set; }

        /// <summary>
        /// The type of amenity provided (e.g., BAGGAGE, SEAT).
        /// </summary>
        public string amenityType { get; set; }

        /// <summary>
        /// Provider of the amenity service.
        /// </summary>
        public AmenityProvider amenityProvider { get; set; }
    }
}
