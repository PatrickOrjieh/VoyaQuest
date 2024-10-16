namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Represents metadata such as pagination and result count.
    /// </summary>
    public class Meta
    {
        /// <summary>
        /// The count of flight offers in the response.
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// Links to related resources (e.g., pagination links).
        /// </summary>
        public Links links { get; set; }
    }
}
