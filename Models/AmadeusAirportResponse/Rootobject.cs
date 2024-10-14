namespace VoyaQuest.Models.AmadeusAirportResponse
{

    /// <summary>
    /// Root object containing meta information and airport data.
    /// </summary>
    public class Rootobject
    {
        /// <summary>
        /// Metadata about the response such as count and pagination links.
        /// </summary>
        public Meta meta { get; set; }

        /// <summary>
        /// Array of airport or city data.
        /// </summary>
        public Airport[] data { get; set; }
    }
}
