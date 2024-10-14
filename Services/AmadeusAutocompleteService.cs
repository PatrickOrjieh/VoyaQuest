using System.Net.Http.Headers;
using System.Text.Json;
using VoyaQuest.Interfaces;
using VoyaQuest.Models;
using VoyaQuest.Models.AmadeusAirportResponse;

namespace VoyaQuest.Services
{
    /// <summary>
    /// Service providing airport autocomplete functionality via the Amadeus API.
    /// </summary>
    public class AmadeusAutocompleteService : IAirportAutocompleteService
    {
        private readonly HttpClient _httpClient;
        private string _accessToken;

        // API URLs
        private const string TokenUrl = "https://test.api.amadeus.com/v1/security/oauth2/token";
        private const string AirportSearchUrl = "https://test.api.amadeus.com/v1/reference-data/locations?subType=AIRPORT,CITY&keyword={0}&page[limit]=10";

        /// <summary>
        /// Initializes the service with the provided HTTP client.
        /// </summary>
        /// <param name="httpClient">The HTTP client to be used for API calls.</param>
        public AmadeusAutocompleteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Fetches a list of airports matching the provided query.
        /// </summary>
        /// <param name="query">The search term for airport/city names.</param>
        /// <returns>A list of matching airports.</returns>
        public async Task<List<Airport>> GetAirportsAsync(string query)
        {
            if (string.IsNullOrEmpty(_accessToken))
            {
                await AuthenticateAsync();
            }

            try
            {
                string requestUrl = string.Format(AirportSearchUrl, query);
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);

                HttpResponseMessage response = await _httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Rootobject? rootObject = JsonSerializer.Deserialize<Rootobject>(content);
                    return rootObject?.data?.ToList() ?? new List<Airport>();
                }
                else
                {
                    Console.WriteLine($"Error: Received HTTP {response.StatusCode} from Amadeus API.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while fetching airports: {ex.Message}");
            }
            return new List<Airport>();
        }

        /// <summary>
        /// Authenticates with the Amadeus API to retrieve an access token.
        /// </summary>
        /// <returns>An asynchronous task that performs authentication.</returns>
        private async Task AuthenticateAsync()
        {
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
                    AmadeusTokenResponse? tokenResponse = JsonSerializer.Deserialize<AmadeusTokenResponse>(content);
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
    }
}
