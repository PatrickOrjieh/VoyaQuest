﻿namespace VoyaQuest.Models.HotelbedsResponse
{
    public class Facility
    {
        public int? facilityCode { get; set; }
        public int? facilityGroupCode { get; set; }
        public int? order { get; set; }
        public bool? indYesOrNo { get; set; }
        public int? number { get; set; }
        public bool? voucher { get; set; }
        public bool? indLogic { get; set; }
        public bool? indFee { get; set; }
        public int? distance { get; set; }
        public double? amount { get; set; }
        public string? currency { get; set; }
        public string? applicationType { get; set; }
        public string? timeFrom { get; set; }
        public string? timeTo { get; set; }
        public string? dateTo { get; set; }
        public int? ageFrom { get; set; }
        public int? ageTo { get; set; }
    }
}
