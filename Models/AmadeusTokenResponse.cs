using System.Text.Json.Serialization;

namespace VoyaQuest.Models
{
    /// <summary>
    /// This class represents the response from the Amadeus API for token generation.
    /// </summary>
    public class AmadeusTokenResponse
    {
        /// <summary>
        /// Represents the access token returned by the API.
        /// </summary>
        private string accessToken;

        /// <summary>
        /// Represents the token type returned by the API.
        /// </summary>
        private string tokenType;

        /// <summary>
        /// Represents the time in seconds until the token expires.
        /// </summary>
        private int expiresIn;

        /// <summary>
        /// To access the access token returned by the API.
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken
        {
            get { return accessToken; }
            set { accessToken = value; }
        }

        /// <summary>
        /// To access the type of the token returned by the API.
        /// </summary>
        [JsonPropertyName("token_type")]
        public string TokenType
        {
            get { return tokenType; }
            set { tokenType = value; }
        }

        /// <summary>
        /// To access the time in seconds until the token expires.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int ExpiresIn
        {
            get { return expiresIn; }
            set { expiresIn = value; }
        }
    }
}
