namespace VoyaQuest.Models.HotelbedsResponse
{
    /// <summary>
    /// Represents the type of accommodation offered by a hotel.
    /// </summary>
    public class Accommodationtype
    {
        public string code { get; set; }
        public string typeDescription { get; set; }
        public Typemultidescription typeMultiDescription { get; set; }
    }
}
