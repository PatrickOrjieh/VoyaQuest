namespace VoyaQuest.Models.AmadeusAirportResponse
{
    /// <summary>
    /// Represents individual airport or city data.
    /// </summary>
    public class Airport
    {
        /// <summary>
        /// The type of location, e.g., "location".
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Subtype of location, e.g., "AIRPORT" or "CITY".
        /// </summary>
        public string subType { get; set; }

        /// <summary>
        /// Name of the airport or city.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Detailed name of the location (airport or city).
        /// </summary>
        public string detailedName { get; set; }

        /// <summary>
        /// Unique identifier of the location.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// A self-referencing link to the location.
        /// </summary>
        public Self self { get; set; }

        /// <summary>
        /// Timezone offset from UTC.
        /// </summary>
        public string timeZoneOffset { get; set; }

        /// <summary>
        /// IATA code of the airport or city.
        /// </summary>
        public string iataCode { get; set; }

        /// <summary>
        /// Geographical coordinates of the location.
        /// </summary>
        public Geocode geoCode { get; set; }

        /// <summary>
        /// Address details of the location.
        /// </summary>
        public Address address { get; set; }

        /// <summary>
        /// Analytics data related to travelers.
        /// </summary>
        public Analytics analytics { get; set; }
    }
}
