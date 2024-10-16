namespace VoyaQuest.Models.HotelbedsResponse
{
    /// <summary>
    /// Represents audit data returned from the API, including environment and request information.
    /// </summary>
    public class Auditdata
    {
        public string[] environment { get; set; }
        public string processTime { get; set; }
        public string release { get; set; }
        public string requestHost { get; set; }
        public string serverId { get; set; }
        public string timestamp { get; set; }
    }
}
