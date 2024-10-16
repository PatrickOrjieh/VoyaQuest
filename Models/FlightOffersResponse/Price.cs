using System.Text.Json.Serialization;

namespace VoyaQuest.Models.FlightOffersResponse
{
    /// <summary>
    /// Represents pricing information such as currency and total price.
    /// </summary>
    public class Price
    {
        /// <summary>
        /// The currency of the price.
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// The total price including all fees.
        /// </summary>
        public string total { get; set; }

        /// <summary>
        /// The base price (excluding additional fees).
        /// </summary>
        [JsonPropertyName("base")]
        public string _base { get; set; }

        /// <summary>
        /// List of additional fees.
        /// </summary>
        public Fee[] fees { get; set; }

        /// <summary>
        /// The grand total including all fees and services.
        /// </summary>
        public string grandTotal { get; set; }

        /// <summary>
        /// List of additional services like checked bags.
        /// </summary>
        public AdditionalService[] additionalServices { get; set; }
    }
}
