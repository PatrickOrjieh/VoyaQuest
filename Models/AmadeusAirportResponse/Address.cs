namespace VoyaQuest.Models.AmadeusAirportResponse
{
    /// <summary>
    /// Address details for the location including city, country, and state.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Name of the city where the location is.
        /// </summary>
        public string cityName { get; set; }

        /// <summary>
        /// Code of the city where the location is.
        /// </summary>
        public string cityCode { get; set; }

        /// <summary>
        /// Name of the country where the location is.
        /// </summary>
        public string countryName { get; set; }

        /// <summary>
        /// Code of the country where the location is.
        /// </summary>
        public string countryCode { get; set; }

        /// <summary>
        /// Code of the state or province where the location is.
        /// </summary>
        public string stateCode { get; set; }

        /// <summary>
        /// Code of the region where the location is.
        /// </summary>
        public string regionCode { get; set; }
    }
}
