namespace VoyaQuest.Models.HotelbedsResponse
{
    /// <summary>
    /// Represents the category of the hotel, including its type and description.
    /// </summary>
    public class Category
    {
        public string accommodationType { get; set; }
        public string code { get; set; }
        public Description description { get; set; }
        public string group { get; set; }
        public int simpleCode { get; set; }
    }
}
