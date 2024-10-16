﻿namespace VoyaQuest.Interfaces
{
    /// <summary>
    /// This interface represents the service that provides Hotelbeds API functionality.
    /// </summary>
    public interface IHotelbedsService
    {
        /// <summary>
        /// This method retrieves the status of the Hotelbeds API.
        /// </summary>
        /// <returns><Returns a string representing the status of the Hotelbeds API./returns>
        Task<HttpResponseMessage> GetApiStatusAsync();
    }
}