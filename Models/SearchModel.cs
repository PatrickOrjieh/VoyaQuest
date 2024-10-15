namespace VoyaQuest.Models
{
    /// <summary>
    /// This class represents the search model of the user in the flight search form.
    /// </summary>
    public class SearchModel
    {
        /// <summary>
        /// This property represents the type of trip selected by the user.
        /// </summary>
        private string tripType = "return";

        /// <summary>
        /// This property represents the departure airport selected by the user.
        /// </summary>
        private string departureAirport;

        /// <summary>
        /// This property represents the destination airport selected by the user.
        /// </summary>
        private string destinationAirport;

        /// <summary>
        /// This property represents the departure date selected by the user.
        /// </summary>
        private DateTime? departureDate;

        /// <summary>
        /// This property represents the return date selected by the user.
        /// </summary>
        private DateTime? returnDate;

        /// <summary>
        /// This property represents the class of the cabin selected by the user.
        /// </summary>
        private string cabinClass = "economy";

        /// <summary>
        /// This property represents the travel details of the user in the flight search form.
        /// </summary>
        private TravelDetails travelDetails = new TravelDetails();

        //Getters and Setters
        public string TripType
        {
            get { return tripType; }
            set { tripType = value; }
        }

        public string DepartureAirport
        {
            get { return departureAirport; }
            set { departureAirport = value; }
        }

        public string DestinationAirport
        {
            get { return destinationAirport; }
            set { destinationAirport = value; }
        }

        public DateTime? DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }

        public DateTime? ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        public string CabinClass
        {
            get { return cabinClass; }
            set { cabinClass = value; }
        }

        public TravelDetails TravelDetails
        {
            get { return travelDetails; }
            set { travelDetails = value; }
        }

        // To string method to see the output that is being passed to the API
        public override string ToString()
        {
            return "TripType: " + tripType + ", DepartureAirport: " + departureAirport + ", DestinationAirport: " + destinationAirport + ", DepartureDate: " + departureDate + ", ReturnDate: " + returnDate + ", CabinClass: " + cabinClass + ", TravelDetails: " + travelDetails;
        }
    }
}
