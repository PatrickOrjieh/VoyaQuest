﻿namespace VoyaQuest.Models.HotelbedsResponse
{
    public class Rootobject
    {
        public int? from { get; set; }
        public int? to { get; set; }
        public int? total { get; set; }
        public AuditData auditData { get; set; }
        public List<Hotel> hotels { get; set; }
    }
}
