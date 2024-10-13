namespace VoyaQuest.Models
{
    /// <summary>
    /// This class represents the address of the airport to be used in the flight search form.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// This property represents the city name of the airport.
        /// </summary>
        private string cityName;
        /// <summary>
        /// This property represents the country name of the airport.
        /// </summary>
        private string countryName;

        /// <summary>
        /// To access the city name of the airport.
        /// </summary>
        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

        /// <summary>
        /// To access the country name of the airport.
        /// </summary>
        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }
    }
}
