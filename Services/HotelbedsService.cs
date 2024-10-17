using Microsoft.Extensions.Caching.Memory;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using VoyaQuest.Interfaces;
using VoyaQuest.Models.HotelbedsResponse;

namespace VoyaQuest.Services
{
    public class HotelbedsService: IHotelbedsService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _apiSecret;

        /// <summary>
        /// The memory cache used to store API responses.
        /// </summary>
        private readonly IMemoryCache _cache;

        // API URL
        private const string BaseUrl = "https://api.test.hotelbeds.com/hotel-api/1.0";

        // Cache key
        private const string HotelCacheKey = "CachedHotels";

        /// <summary>
        /// Initializes the Hotelbeds service with the provided HTTP client and loads API key and secret from environment variables.
        /// </summary>
        public HotelbedsService(HttpClient httpClient, IMemoryCache cache)
        {
            _httpClient = httpClient;
            _cache = cache;  // Initialize cache

            // Get API key and secret from environment variables
            _apiKey = Environment.GetEnvironmentVariable("HOTEL_BEDS_API_KEY");
            _apiSecret = Environment.GetEnvironmentVariable("HOTEL_BEDS_API_SECRET");
        }

        /// <summary>
        /// Generates the signature needed for Hotelbeds API requests.
        /// </summary>
        private string GenerateSignature()
        {
            string timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
            string signatureRaw = _apiKey + _apiSecret + timestamp;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(signatureRaw));
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        /// <summary>
        /// Makes a request to the Hotelbeds API to check the status.
        /// </summary>
        public async Task<HttpResponseMessage> GetApiStatusAsync()
        {
            string signature = GenerateSignature();
            string requestUrl = $"{BaseUrl}/status";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Add("Api-key", _apiKey);
            request.Headers.Add("X-Signature", signature);

            return await _httpClient.SendAsync(request);
        }

        /// <summary>
        /// Makes a request to the Hotelbeds API, handles deserialization errors, and caches the response to avoid redundant API calls.
        /// </summary>
        public async Task<List<Hotel>> GetHotelsAsync()
        {
            // Check if the hotels are cached
            if (_cache.TryGetValue(HotelCacheKey, out List<Hotel> cachedHotels))
            {
                Console.WriteLine("Returning cached hotel data.");
                return cachedHotels;
            }

            // Check if there is a local file with cached hotel data
            string filePath = "hotel_response.json";
            if (File.Exists(filePath))
            {
                Console.WriteLine("Loading hotel data from local file.");
                string fileContent = await File.ReadAllTextAsync(filePath);

                return DeserializeHotels(fileContent);
            }

            string signature = GenerateSignature();
            string requestUrl = "https://api.test.hotelbeds.com/hotel-content-api/1.0/hotels";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Add("Api-key", _apiKey);
            request.Headers.Add("X-Signature", signature);

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();

                await File.WriteAllTextAsync(filePath, content);
                Console.WriteLine($"Hotel offers response saved to {filePath}");

                return DeserializeHotels(content);
            }
            else
            {
                Console.WriteLine($"Error: Received HTTP {response.StatusCode} from Hotelbeds API.");
            }

            return new List<Hotel>();
        }

        /// <summary>
        /// Attempts to deserialize the hotel data also skipping over entries that cause deserialization errors.
        /// </summary>
        /// <param name="content">The JSON content to deserialize.</param>
        /// <returns>A list of successfully deserialized hotels.</returns>
        private List<Hotel> DeserializeHotels(string content)
        {
            List<Hotel> validHotels = new List<Hotel>();

            try
            {
                // Deserialize
                Rootobject? hotelResponse = JsonSerializer.Deserialize<Rootobject>(content);

                if (hotelResponse != null && hotelResponse.hotels != null)
                {
                    foreach (var hotel in hotelResponse.hotels)
                    {
                        try
                        {
                            validHotels.Add(hotel);
                            Console.WriteLine($"Successfully deserialized hotel: {hotel.name?.content ?? "Unnamed"}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error deserializing hotel entry: {ex.Message}");
                        }
                    }

                    // Cache the valid hotels
                    _cache.Set(HotelCacheKey, validHotels, TimeSpan.FromHours(24));
                }
                else
                {
                    Console.WriteLine("No hotels found in the response.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing the entire hotel response: {ex.Message}");
            }

            Console.WriteLine($"Successfully deserialized {validHotels.Count} hotels.");
            return validHotels;
        }


    }
}
