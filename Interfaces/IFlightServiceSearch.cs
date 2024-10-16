using VoyaQuest.Models;
using VoyaQuest.Models.FlightOffersResponse;

namespace VoyaQuest.Interfaces
{
    /// <summary>
    /// An interface for the flight service search.
    /// </summary>
    public interface IFlightServiceSearch
    {
        /// <summary>
        /// This method searches for flights based on the search model provided.
        /// </summary>
        /// <param name="searchModel">The search model containing the search criteria.</param>
        /// <returns>Returns a list of flight offers based on the search criteria.</returns>
        Task<List<FlightOffer>> SearchFlightsAsync(SearchModel searchModel);
    }
}
