namespace VoyaQuest.Models
{
    /// <summary>
    /// This class represents the travel details of the user in the flight search form.
    /// </summary>
    public class TravelDetails
    {
        /// <summary>
        /// This property represents the number of adults in the travel group.
        /// </summary>
        private int adultCount = 1;
        /// <summary>
        /// This property represents the number of children in the travel group.
        /// </summary>
        private int childCount = 0;
        /// <summary>
        /// This property represents the number of Cabin bags carried by the travel group.
        /// </summary>
        private int cabinBagCount = 0;
        /// <summary>
        /// This property represents the number of Checked bags carried by the travel group.
        /// </summary>
        private int checkedBagCount = 0;

        /// <summary>
        /// To access the number of children in the travel group.
        /// </summary>
        public int AdultCount
        {
            get { return adultCount; }
            set { adultCount = value; }
        }
        /// <summary>
        /// To access the number of children in the travel group.
        /// </summary>
        public int ChildCount
        {
            get { return childCount; }
            set { childCount = value; }
        }

        /// <summary>
        /// To access the number of Cabin bags carried by the travel group.
        /// </summary>
        public int CabinBagCount
        {
            get { return cabinBagCount; }
            set { cabinBagCount = value; }
        }

        /// <summary>
        /// To access the number of Checked bags carried by the travel group.
        /// </summary>
        public int CheckedBagCount
        {
            get { return checkedBagCount; }
            set { checkedBagCount = value; }
        }


        public string GetPassengerText()
        {
            if (AdultCount == 1 && ChildCount == 0)
                return "1 Adult";
            if (AdultCount == 0 && ChildCount == 1)
                return "1 Child";

            int totalPassengers = AdultCount + ChildCount;
            return $"{totalPassengers} Traveller{(totalPassengers > 1 ? "s" : "")}";
        }

        public string GetBaggageText()
        {
            int totalBags = CabinBagCount + CheckedBagCount;
            return $"{totalBags} Bag{(totalBags > 1 ? "s" : "")}";
        }

        //To string method to see the output that is being passed to the API
        public override string ToString()
        {
            return $"AdultCount: {AdultCount}, ChildCount: {ChildCount}, CabinBagCount: {CabinBagCount}, CheckedBagCount: {CheckedBagCount}";
        }
    }

}
