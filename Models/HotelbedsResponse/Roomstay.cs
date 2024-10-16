namespace VoyaQuest.Models.HotelbedsResponse
{
    public class Roomstay
    {
        public string description { get; set; }
        public int order { get; set; }
        public Roomstayfacility[] roomStayFacilities { get; set; }
        public string stayType { get; set; }
    }
}
