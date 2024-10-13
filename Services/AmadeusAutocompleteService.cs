using System.Net.Http.Headers;
using System.Text.Json;
using VoyaQuest.Interfaces;
using VoyaQuest.Models;

namespace VoyaQuest.Services
{
    /// <summary>
    /// This class represents the service that provides airport autocomplete functionality.
    /// </summary>
    public class AmadeusAutocompleteService : IAirportAutocompleteService
    {
        /// <summary>
        /// This property represents the HTTP client to be used in the service.
        /// </summary>
        private readonly HttpClient _httpClient;
        /// <summary>
        /// This property represents the access token to be used in the service.
        /// </summary>
        private string _accessToken;

        /// <summary>
        /// This constructor initializes the service with the provided HTTP client.
        /// </summary>
        /// <param name="httpClient">the HTTP client to be used in the service</param>
        public AmadeusAutocompleteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// This method calls the Amadeus API to get the list of airports based on the provided query.
        /// </summary>
        /// <param name="query">The query to be used to search for airports</param>
        /// <returns>A list of airports based on the provided query</returns>
        public async Task<List<Airport>> GetAirportsAsync(string query)
        {
            if (string.IsNullOrEmpty(_accessToken))
            {
                await AuthenticateAsync();
            }

            // Create a request to the Amadeus API to get the list of airports based on the provided query and limit the results to 5.
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://test.api.amadeus.com/v1/reference-data/locations?subType=AIRPORT,CITY&keyword={query}&page[limit]=5");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);

            HttpResponseMessage response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                AmadeusAirportResponse? result = JsonSerializer.Deserialize<AmadeusAirportResponse>(content);
                return result?.Data ?? new List<Airport>();
            }

            return new List<Airport>();
        }

        /// <summary>
        /// This method authenticates the service with the Amadeus API to get the access token.
        /// </summary>
        /// <returns>A task representing the asynchronous operation</returns>
        private async Task AuthenticateAsync()
        {
            string? apiKey = Environment.GetEnvironmentVariable("AMADEUS_API_KEY");
            string? apiSecret = Environment.GetEnvironmentVariable("AMADEUS_API_SECRET");

            FormUrlEncodedContent requestContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials"),
                new KeyValuePair<string, string>("client_id", apiKey),
                new KeyValuePair<string, string>("client_secret", apiSecret)
            });

            HttpResponseMessage response = await _httpClient.PostAsync("https://test.api.amadeus.com/v1/security/oauth2/token", requestContent);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                AmadeusTokenResponse? tokenResponse = JsonSerializer.Deserialize<AmadeusTokenResponse>(content);
                _accessToken = tokenResponse?.AccessToken;
            }
        }
    }
}
