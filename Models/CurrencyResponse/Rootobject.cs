namespace VoyaQuest.Models.CurrencyResponse
{
    public class Rootobject
    {
        public string disclaimer { get; set; }
        public string license { get; set; }
        public int timestamp { get; set; }
        public string @base { get; set; }
        public Rates rates { get; set; }
    }
}
