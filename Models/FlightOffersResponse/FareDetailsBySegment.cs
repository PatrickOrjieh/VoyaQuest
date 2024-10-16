using System.Text.Json.Serialization;

namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Fare details for a specific flight segment.
    /// </summary>
    public class FareDetailsBySegment
    {
        /// <summary>
        /// The ID of the segment.
        /// </summary>
        public string segmentId { get; set; }

        /// <summary>
        /// The cabin class for the segment (e.g., ECONOMY, BUSINESS).
        /// </summary>
        public string cabin { get; set; }

        /// <summary>
        /// The fare basis code.
        /// </summary>
        public string fareBasis { get; set; }

        /// <summary>
        /// The branded fare type (e.g., LITE, STANDARD).
        /// </summary>
        public string brandedFare { get; set; }

        /// <summary>
        /// The branded fare label (e.g., LITE).
        /// </summary>
        public string brandedFareLabel { get; set; }

        /// <summary>
        /// The class of service (e.g., A, B, C).
        /// </summary>
        [JsonPropertyName("class")]
        public string _class { get; set; }

        /// <summary>
        /// The included checked bags for the traveler in the segment.
        /// </summary>
        public IncludedCheckedBags includedCheckedBags { get; set; }

        /// <summary>
        /// List of amenities provided during the flight segment.
        /// </summary>
        public Amenity[] amenities { get; set; }
    }
}
