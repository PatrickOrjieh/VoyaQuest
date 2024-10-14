namespace VoyaQuest.Models.AmadeusAirportResponse
{
    /// <summary>
    /// Represents a self-referencing link to the location.
    /// </summary>
    public class Self
    {
        /// <summary>
        /// The URL to access the specific location.
        /// </summary>
        public string href { get; set; }

        /// <summary>
        /// The HTTP methods that can be used to interact with the location.
        /// </summary>
        public string[] methods { get; set; }
    }
}
