namespace VoyaQuest.Models.HotelbedsResponse
{
    public class Wildcard
    {
        public string? roomType { get; set; }
        public string? roomCode { get; set; }
        public string? characteristicCode { get; set; }
        public HotelRoomDescription? hotelRoomDescription { get; set; }
    }
}
