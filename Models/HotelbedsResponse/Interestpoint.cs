namespace VoyaQuest.Models.HotelbedsResponse
{
    /// <summary>
    /// Represents interest points near the hotel.
    /// </summary>
    public class Interestpoint
    {
        public int distance { get; set; }
        public int facilityCode { get; set; }
        public int facilityGroupCode { get; set; }
        public bool fee { get; set; }
        public int order { get; set; }
        public string poiName { get; set; }
    }
}
