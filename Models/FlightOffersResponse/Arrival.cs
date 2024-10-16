namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Represents the arrival information such as airport and time.
    /// </summary>
    public class Arrival
    {
        /// <summary>
        /// The IATA code of the arrival airport.
        /// </summary>
        public string iataCode { get; set; }

        /// <summary>
        /// The terminal at the arrival airport.
        /// </summary>
        public string terminal { get; set; }

        /// <summary>
        /// The arrival time.
        /// </summary>
        public DateTime at { get; set; }
    }
}
