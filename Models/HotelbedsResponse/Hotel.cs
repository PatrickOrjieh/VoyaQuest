namespace VoyaQuest.Models.HotelbedsResponse
{
    /// <summary>
    /// Represents a hotel and its detailed information, such as accommodation type, category, and facilities.
    /// </summary>
    public class Hotel
    {
        public string S2C { get; set; }
        public Accommodationtype accommodationType { get; set; }
        public string accommodationTypeCode { get; set; }
        public Address address { get; set; }
        public string[] boardCodes { get; set; }
        public Board[] boards { get; set; }
        public Category category { get; set; }
        public string categoryCode { get; set; }
        public Categorygroup categoryGroup { get; set; }
        public string categoryGroupCode { get; set; }
        public Chain chain { get; set; }
        public string chainCode { get; set; }
        public City city { get; set; }
        public int code { get; set; }
        public Coordinates coordinates { get; set; }
        public Country country { get; set; }
        public string countryCode { get; set; }
        public Description4 description { get; set; }
        public Destination destination { get; set; }
        public string destinationCode { get; set; }
        public string email { get; set; }
        public int exclusiveDeal { get; set; }
        public Facility[] facilities { get; set; }
        public int giataCode { get; set; }
        public Image[] images { get; set; }
        public Interestpoint[] interestPoints { get; set; }
        public Issue[] issues { get; set; }
        public string lastUpdate { get; set; }
        public int license { get; set; }
        public Name3 name { get; set; }
        public Phone[] phones { get; set; }
        public int postalCode { get; set; }
        public int ranking { get; set; }
        public Room[] rooms { get; set; }
        public int[] segmentCodes { get; set; }
        public Segment[] segments { get; set; }
        public State1 state { get; set; }
        public string stateCode { get; set; }
        public Terminal[] terminals { get; set; }
        public string web { get; set; }
        public Wildcard[] wildcards { get; set; }
        public Zone1 zone { get; set; }
        public int zoneCode { get; set; }
    }
}
