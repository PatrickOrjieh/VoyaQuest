namespace VoyaQuest.Models
{
    /// <summary>
    /// This class represents the airport to be used in the flight search form.
    /// </summary>
    public class Airport
    {
        /// <summary>
        /// This property represents the name of the airport.
        /// </summary>
        private string name;
        /// <summary>
        /// This property represents the IATA code of the airport.
        /// </summary>
        private string iataCode;
        /// <summary>
        /// This property represents the type of the airport.
        /// </summary>
        private string subType;
        /// <summary>
        /// This property represents the address of the airport.
        /// </summary>
        private Address address;

        /// <summary>
        /// To access the name of the airport.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// To access the IATA code of the airport.
        /// </summary>
        public string IataCode
        {
            get { return iataCode; }
            set { iataCode = value; }
        }

        /// <summary>
        /// To access the type of the airport.
        /// </summary>
        public string SubType
        {
            get { return subType; }
            set { subType = value; }
        }

        /// <summary>
        /// To access the address of the airport.
        /// </summary>
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
