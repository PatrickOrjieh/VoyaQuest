namespace VoyaQuest.Models.HotelbedsResponse
{
    /// <summary>
    /// Represents the category group information for a hotel.
    /// </summary>
    public class Categorygroup
    {
        public string code { get; set; }
        public Description1 description { get; set; }
        public Name name { get; set; }
        public int order { get; set; }
    }
}
