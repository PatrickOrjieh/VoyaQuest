namespace VoyaQuest.Models.HotelbedsResponse
{
    /// <summary>
    /// Represents the destination information for the hotel.
    /// </summary>
    public class Destination
    {
        public string code { get; set; }
        public string countryCode { get; set; }
        public Groupzone[] groupZones { get; set; }
        public string isoCode { get; set; }
        public Name1 name { get; set; }
        public Zone[] zones { get; set; }
    }
}
