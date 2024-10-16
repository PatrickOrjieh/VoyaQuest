using System.Net.Http.Headers;
using System.Text.Json;
using VoyaQuest.Interfaces;
using VoyaQuest.Models.AmadeusAirportResponse;

namespace VoyaQuest.Services
{
    /// <summary>
    /// Service providing airport autocomplete functionality via the Amadeus API.
    /// </summary>
    public class AmadeusAutocompleteService : AmadeusBaseService, IAirportAutocompleteService
    {
        private const string AirportSearchUrl = "https://test.api.amadeus.com/v1/reference-data/locations?subType=AIRPORT,CITY&keyword={0}&page[limit]=50";

        /// <summary>
        /// Initializes the service with the provided HTTP client.
        /// </summary>
        /// <param name="httpClient">The HTTP client to be used for API calls.</param>
        public AmadeusAutocompleteService(HttpClient httpClient) : base(httpClient) { }

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

                HttpResponseMessage response = await SendAmadeusRequestAsync(request);

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
    }
}
