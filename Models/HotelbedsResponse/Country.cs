namespace VoyaQuest.Models.HotelbedsResponse
{
    /// <summary>
    /// Represents the country details of the hotel, including states and ISO codes.
    /// </summary>
    public class Country
    {
        public string code { get; set; }
        public Description3 description { get; set; }
        public string isoCode { get; set; }
        public State[] states { get; set; }
    }
}
