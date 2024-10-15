using System.Net.Http.Headers;
using System.Text.Json;
using VoyaQuest.Models;

namespace VoyaQuest.Services
{
    /// <summary>
    /// This class represents the base service for Amadeus API services.
    /// </summary>
    public abstract class AmadeusBaseService
    {
        protected readonly HttpClient _httpClient;
        protected string _accessToken;

        // API URLs
        private const string TokenUrl = "https://test.api.amadeus.com/v1/security/oauth2/token";

        /// <summary>
        /// Provides a base service for Amadeus API services and is protected so that it can only be used by derived classes.
        /// </summary>
        /// <param name="httpClient">The HTTP client to be used for API calls.</param>
        protected AmadeusBaseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Authenticates with the Amadeus API to retrieve an access token.
        /// </summary>
        /// <returns>An asynchronous task that performs authentication.</returns>
        protected async Task AuthenticateAsync()
        {
            if (!string.IsNullOrEmpty(_accessToken)) return;

            try
            {
                string? apiKey = Environment.GetEnvironmentVariable("AMADEUS_API_KEY");
                string? apiSecret = Environment.GetEnvironmentVariable("AMADEUS_API_SECRET");

                var requestContent = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("grant_type", "client_credentials"),
                    new KeyValuePair<string, string>("client_id", apiKey),
                    new KeyValuePair<string, string>("client_secret", apiSecret)
                });

                HttpResponseMessage response = await _httpClient.PostAsync(TokenUrl, requestContent);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var tokenResponse = JsonSerializer.Deserialize<AmadeusTokenResponse>(content);
                    _accessToken = tokenResponse?.AccessToken;
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode} - {errorContent}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while authenticating: {ex.Message}");
            }
        }

        /// <summary>
        /// This method sends an Amadeus API request with the access token.
        /// </summary>
        /// <param name="request">The request to be sent to the API.</param>
        /// <returns>Returns the response from the API.</returns>
        protected async Task<HttpResponseMessage> SendAmadeusRequestAsync(HttpRequestMessage request)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
            return await _httpClient.SendAsync(request);
        }
    }
}
