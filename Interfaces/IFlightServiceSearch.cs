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

        /// <summary>
        /// This method sorts the list of flights based on the provided sort criteria.
        /// </summary>
        /// <param name="flights">The list of flights to sort.</param>
        /// <param name="sortBy">The criteria to sort by.</param>
        /// <param name="ascending">The sort order.</param>
        /// <returns>Returns the sorted list of flights.</returns>
        List<FlightOffer> SortFlights(List<FlightOffer> flights, string sortBy, bool ascending);
    }
}
