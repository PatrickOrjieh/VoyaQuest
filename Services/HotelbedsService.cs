using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using VoyaQuest.Interfaces;

namespace VoyaQuest.Services
{
    public class HotelbedsService: IHotelbedsService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _apiSecret;

        // API URL
        private const string BaseUrl = "https://api.test.hotelbeds.com/hotel-api/1.0";

        /// <summary>
        /// Initializes the Hotelbeds service with the provided HTTP client and loads API key and secret from environment variables.
        /// </summary>
        public HotelbedsService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            // Get API key and secret from .env file
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
    }
}
