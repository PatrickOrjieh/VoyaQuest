using VoyaQuest.Models.AmadeusAirportResponse;

namespace VoyaQuest.Interfaces
{
    /// <summary>
    /// This interface represents the service that provides airport autocomplete functionality.
    /// </summary>
    public interface IAirportAutocompleteService
    {
        /// <summary>
        /// This method retrieves a list of airports based on the query.
        /// </summary>
        /// <param name="query">The query to search for.</param>
        /// <returns>Returns a list of airports.</returns>
        Task<List<Airport>> GetAirportsAsync(string query);
    }
}
