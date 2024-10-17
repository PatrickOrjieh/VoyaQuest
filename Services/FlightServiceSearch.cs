using System.Text.Json;
using VoyaQuest.Models;
using VoyaQuest.Models.FlightOffersResponse;
using VoyaQuest.Interfaces;
using System.Net.Http.Headers;

namespace VoyaQuest.Services
{
    public class FlightServiceSearch : AmadeusBaseService, IFlightServiceSearch
    {
        // API URLs
        private const string FlightOffersSearchUrl = "https://test.api.amadeus.com/v2/shopping/flight-offers";

        public FlightServiceSearch(HttpClient httpClient) : base(httpClient) 
        {
        }

        /// <summary>
        /// This method searches for flight offers based on the provided search model.
        /// </summary>
        /// <param name="searchModel">The search model containing the search criteria.</param>
        /// <returns>Returns a list of flight offers based on the search criteria.</returns>
        public async Task<List<FlightOffer>> SearchFlightsAsync(SearchModel searchModel)
        {
            if (string.IsNullOrEmpty(_accessToken))
            {
                await AuthenticateAsync();
            }

            try
            {
                string requestUrl = $"{FlightOffersSearchUrl}?" +
                                    $"originLocationCode={ExtractIataCode(searchModel.DepartureAirport)}&" +
                                    $"destinationLocationCode={ExtractIataCode(searchModel.DestinationAirport)}&" +
                                    $"departureDate={searchModel.DepartureDate?.ToString("yyyy-MM-dd")}&" +
                                    $"{(searchModel.TripType == "return" ? $"returnDate={searchModel.ReturnDate?.ToString("yyyy-MM-dd")}&" : "")}" +
                                    $"adults={searchModel.TravelDetails.AdultCount}&" +
                                    $"children={searchModel.TravelDetails.ChildCount}&" +
                                    $"travelClass={searchModel.CabinClass.ToUpper()}&" +
                                    $"nonStop=true&" +
                                    $"currencyCode=USD&" +
                                    $"max=2";

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);

                HttpResponseMessage response = await _httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Flight offers response: {content}");
                    Rootobject? flightOffersResponse = JsonSerializer.Deserialize<Rootobject>(content);
                    return flightOffersResponse?.data ?? new List<FlightOffer>();
                }
                else
                {
                    Console.WriteLine($"Error: Received HTTP {response.StatusCode} from Amadeus API.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while fetching flight offers: {ex.Message}");
            }

            return new List<FlightOffer>();
        }

        private string ExtractIataCode(string airport)
        {
            // This function extracts the IATA code from a string like "DUBLIN (DBN)"
            return airport?.Substring(airport.LastIndexOf('(') + 1, 3).ToUpper();
        }
    }
}
