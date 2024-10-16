namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Represents the departure information such as airport and time.
    /// </summary>
    public class Departure
    {
        /// <summary>
        /// The IATA code of the departure airport.
        /// </summary>
        public string iataCode { get; set; }

        /// <summary>
        /// The terminal at the departure airport.
        /// </summary>
        public string terminal { get; set; }

        /// <summary>
        /// The departure time.
        /// </summary>
        public DateTime at { get; set; }
    }
}
