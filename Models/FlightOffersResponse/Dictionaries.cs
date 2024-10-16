namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Dictionaries containing mapping for various entities like locations, aircraft, etc.
    /// </summary>
    public class Dictionaries
    {
        /// <summary>
        /// A dictionary mapping location codes to location details.
        /// </summary>
        public Dictionary<string, Location> locations { get; set; }

        /// <summary>
        /// A dictionary mapping aircraft codes to their names.
        /// </summary>
        public Dictionary<string, string> aircraft { get; set; }

        /// <summary>
        /// A dictionary mapping currency codes to their descriptions.
        /// </summary>
        public Dictionary<string, string> currencies { get; set; }

        /// <summary>
        /// A dictionary mapping airline carrier codes to their names.
        /// </summary>
        public Dictionary<string, string> carriers { get; set; }
    }
}
