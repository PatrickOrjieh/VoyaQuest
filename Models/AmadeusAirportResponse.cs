namespace VoyaQuest.Models
{
    /// <summary>
    /// This class represents the response from the Amadeus API for airport autocomplete.
    /// </summary>
    public class AmadeusAirportResponse
    {
        /// <summary>
        /// This property represents the list of airports returned by the API.
        /// </summary>
        public List<Airport> data;

        /// <summary>
        /// To access the list of airports returned by the API.
        /// </summary>
        public List<Airport> Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
