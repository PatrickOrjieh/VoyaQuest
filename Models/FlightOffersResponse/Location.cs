namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Represents location information like city and country codes.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// The IATA city code.
        /// </summary>
        public string cityCode { get; set; }

        /// <summary>
        /// The ISO country code.
        /// </summary>
        public string countryCode { get; set; }
    }
}
