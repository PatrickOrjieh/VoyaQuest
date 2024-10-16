namespace VoyaQuest.Models.HotelbedsResponse
{
    public class Room
    {
        public string characteristicCode { get; set; }
        public string description { get; set; }
        public string roomCode { get; set; }
        public Roomfacility[] roomFacilities { get; set; }
        public Roomstay[] roomStays { get; set; }
        public string roomType { get; set; }
    }
}
