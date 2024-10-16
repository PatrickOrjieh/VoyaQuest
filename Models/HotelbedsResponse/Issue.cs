namespace VoyaQuest.Models.HotelbedsResponse
{
    /// <summary>
    /// Represents issues or refurbishments affecting a hotel during a specific period.
    /// </summary>
    public class Issue
    {
        public bool alternative { get; set; }
        public string dateFrom { get; set; }
        public string dateTo { get; set; }
        public Description10 description { get; set; }
        public string issueCode { get; set; }
        public string issueType { get; set; }
        public int order { get; set; }
    }
}
