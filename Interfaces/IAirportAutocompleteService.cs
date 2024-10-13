using VoyaQuest.Models;

namespace VoyaQuest.Interfaces
{
    /// <summary>
    /// This interface represents the service that provides airport autocomplete functionality.
    /// </summary>
    public interface IAirportAutocompleteService
    {
        Task<List<Airport>> GetAirportsAsync(string query);
    }
}
