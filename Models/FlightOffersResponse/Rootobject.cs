namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Represents the flight offers response returned by the Amadeus API.
    /// </summary>
    public class Rootobject
    {
        /// <summary>
        /// Metadata information like the count of results and pagination links.
        /// </summary>
        public Meta meta { get; set; }

        /// <summary>
        /// List of flight offers available in the response.
        /// </summary>
        public List<FlightOffer> data { get; set; }

        /// <summary>
        /// Dictionaries containing lookup values for locations, aircraft, currencies, and carriers.
        /// </summary>
        public Dictionaries dictionaries { get; set; }
    }
}
