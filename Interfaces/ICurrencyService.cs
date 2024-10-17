namespace VoyaQuest.Interfaces
{
    /// <summary>
    /// This interface defines the methods for currency conversion.
    /// </summary>
    public interface ICurrencyService
    {
        /// <summary>
        /// This method retrieves the exchange rate between two currencies.
        /// </summary>
        /// <param name="fromCurrency">The currency to convert from.</param>
        /// <param name="toCurrency">The currency to convert to.</param>
        /// <returns>Returns the exchange rate between the two currencies.</returns>
        Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency);
        /// <summary>
        /// This method converts an amount from one currency to another.
        /// </summary>
        /// <param name="amount">The amount to convert.</param>
        /// <param name="fromCurrency">the currency to convert from.</param>
        /// <param name="toCurrency">The currency to convert to.</param>
        /// <returns>Returns the converted amount.</returns>
        Task<decimal> ConvertAmountAsync(decimal amount, string fromCurrency, string toCurrency);
    }
}
