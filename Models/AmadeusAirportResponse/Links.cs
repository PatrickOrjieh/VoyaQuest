namespace VoyaQuest.Models.AmadeusAirportResponse
{
    /// <summary>
    /// Class representing pagination links (self, next, and last).
    /// </summary>
    public class Links
    {
        /// <summary>
        /// Link to the current page of results.
        /// </summary>
        public string self { get; set; }

        /// <summary>
        /// Link to the next page of results.
        /// </summary>
        public string next { get; set; }

        /// <summary>
        /// Link to the last page of results.
        /// </summary>
        public string last { get; set; }
    }
}
