namespace VoyaQuest.Models.AmadeusAirportResponse
{
    /// <summary>
    /// Metadata about the response including the count and links for pagination.
    /// </summary>
    public class Meta
    {
        /// <summary>
        /// The total number of results returned.
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// Links to the current, next, and last pages of results.
        /// </summary>
        public Links links { get; set; }
    }
}
