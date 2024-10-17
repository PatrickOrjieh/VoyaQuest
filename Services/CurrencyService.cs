using Microsoft.Extensions.Caching.Memory;
using VoyaQuest.Interfaces;
using VoyaQuest.Models.CurrencyResponse;
using System.Text.Json;

namespace VoyaQuest.Services
{
    /// <summary>
    /// This class provides currency conversion functionality.
    /// </summary>
    public class CurrencyService :ICurrencyService
    {
        /// <summary>
        /// This property represents the HttpClient used to make requests to the Open Exchange Rate API.
        /// </summary>
        private readonly HttpClient _httpClient;

        private readonly string _apiKey = Environment.GetEnvironmentVariable("OPEN_EXCHANGE_RATE_API_KEY");

        /// <summary>
        /// This the url for the Open Exchange Rate API.
        /// </summary>
        private const string ApiUrl = "https://openexchangerates.org/api/latest.json";

        /// <summary>
        /// This is used to cache the exchange rates.
        /// </summary>
        private static readonly MemoryCache _cache = new MemoryCache(new MemoryCacheOptions());


        /// <summary>
        /// This constructor initializes the CurrencyService with an HttpClient.
        /// </summary>
        /// <param name="httpClient"></param>
        public CurrencyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// This method retrieves the exchange rate between two currencies.
        /// </summary>
        /// <param name="fromCurrency">The currency to convert from.</param>
        /// <param name="toCurrency">The currency to convert to.</param>
        /// <returns>Returns the exchange rate between the two currencies.</returns>
        /// <exception cref="Exception">Thrown when the exchange rate cannot be retrieved.</exception>
        public async Task<double> GetExchangeRateAsync(string fromCurrency, string toCurrency)
        {
            // First, check if we have the rate cached
            string cacheKey = $"{fromCurrency}_{toCurrency}_rate";
            if (_cache.TryGetValue(cacheKey, out double cachedRate))
            {
                Console.WriteLine("Using cached rate");
                return cachedRate;
            }

            // Fetch the latest exchange rates
            Rootobject rates = await FetchLatestRatesAsync();

            if (rates == null || !rates.rates.GetType().GetProperties().Any(p => p.Name == fromCurrency) ||
            !rates.rates.GetType().GetProperties().Any(p => p.Name == toCurrency))
            {
                throw new Exception("Unable to retrieve exchange rate for the specified currencies.");
            }

            // Calculate the exchange rate
            double fromRate = (double)rates.rates.GetType().GetProperty(fromCurrency)?.GetValue(rates.rates, null);
            double toRate = (double)rates.rates.GetType().GetProperty(toCurrency)?.GetValue(rates.rates, null);
            double rate = toRate / fromRate;

            // Cache the rate for future calls
            _cache.Set(cacheKey, rate, TimeSpan.FromMinutes(60));

            return rate;
        }

        /// <summary>
        /// This method converts an amount from one currency to another.
        /// </summary>
        /// <param name="amount">The amount to convert.</param>
        /// <param name="fromCurrency">The currency to convert from.</param>
        /// <param name="toCurrency">The currency to convert to.</param>
        /// <returns>Returns the converted amount.</returns>
        public async Task<double> ConvertAmountAsync(double amount, string fromCurrency, string toCurrency)
        {
            double exchangeRate = await GetExchangeRateAsync(fromCurrency, toCurrency);
            return amount * exchangeRate;
        }

        /// <summary>
        /// This method fetches the latest exchange rates from the Open Exchange Rate API.
        /// </summary>
        /// <returns>Returns the latest exchange rates.</returns>
        /// <exception cref="Exception">Thrown when the exchange rates cannot be retrieved.</exception>
        private async Task<Rootobject> FetchLatestRatesAsync()
        {
            // Build the request URL
            string requestUrl = $"{ApiUrl}?app_id={_apiKey}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                Rootobject? rates = JsonSerializer.Deserialize<Rootobject>(jsonResponse);

                return rates;
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"HTTP Request error: {httpEx.Message}");
                throw new Exception("Error fetching exchange rates from the API. Please try again later.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General error: {ex.Message}");
                throw new Exception("An unexpected error occurred while fetching exchange rates.");
            }
        }
    }
}
