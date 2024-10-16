namespace VoyaQuest.Models.HotelbedsResponse
{
    /// <summary>
    /// Represents the root object for the hotel API response.
    /// </summary>
    public class Rootobject
    {
        public Auditdata auditData { get; set; }
        public int from { get; set; }
        public Hotel[] hotels { get; set; }
        public int to { get; set; }
        public int total { get; set; }
    }
}
