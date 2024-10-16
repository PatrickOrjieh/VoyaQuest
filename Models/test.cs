//namespace VoyaQuest.Models
//{

//    public class Rootobject
//    {
//        public Auditdata auditData { get; set; }
//        public int from { get; set; }
//        public Hotel[] hotels { get; set; }
//        public int to { get; set; }
//        public int total { get; set; }
//    }

//    public class Auditdata
//    {
//        public string[] environment { get; set; }
//        public string processTime { get; set; }
//        public string release { get; set; }
//        public string requestHost { get; set; }
//        public string serverId { get; set; }
//        public string timestamp { get; set; }
//    }

//    public class Hotel
//    {
//        public string S2C { get; set; }
//        public Accommodationtype accommodationType { get; set; }
//        public string accommodationTypeCode { get; set; }
//        public Address address { get; set; }
//        public string[] boardCodes { get; set; }
//        public Board[] boards { get; set; }
//        public Category category { get; set; }
//        public string categoryCode { get; set; }
//        public Categorygroup categoryGroup { get; set; }
//        public string categoryGroupCode { get; set; }
//        public Chain chain { get; set; }
//        public string chainCode { get; set; }
//        public City city { get; set; }
//        public int code { get; set; }
//        public Coordinates coordinates { get; set; }
//        public Country country { get; set; }
//        public string countryCode { get; set; }
//        public Description4 description { get; set; }
//        public Destination destination { get; set; }
//        public string destinationCode { get; set; }
//        public string email { get; set; }
//        public int exclusiveDeal { get; set; }
//        public Facility[] facilities { get; set; }
//        public int giataCode { get; set; }
//        public Image[] images { get; set; }
//        public Interestpoint[] interestPoints { get; set; }
//        public Issue[] issues { get; set; }
//        public string lastUpdate { get; set; }
//        public int license { get; set; }
//        public Name3 name { get; set; }
//        public Phone[] phones { get; set; }
//        public int postalCode { get; set; }
//        public int ranking { get; set; }
//        public Room[] rooms { get; set; }
//        public int[] segmentCodes { get; set; }
//        public Segment[] segments { get; set; }
//        public State1 state { get; set; }
//        public string stateCode { get; set; }
//        public Terminal[] terminals { get; set; }
//        public string web { get; set; }
//        public Wildcard[] wildcards { get; set; }
//        public Zone1 zone { get; set; }
//        public int zoneCode { get; set; }
//    }

//    public class Accommodationtype
//    {
//        public string code { get; set; }
//        public string typeDescription { get; set; }
//        public Typemultidescription typeMultiDescription { get; set; }
//    }

//    public class Typemultidescription
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Address
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Category
//    {
//        public string accommodationType { get; set; }
//        public string code { get; set; }
//        public Description description { get; set; }
//        public string group { get; set; }
//        public int simpleCode { get; set; }
//    }

//    public class Description
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Categorygroup
//    {
//        public string code { get; set; }
//        public Description1 description { get; set; }
//        public Name name { get; set; }
//        public int order { get; set; }
//    }

//    public class Description1
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Name
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Chain
//    {
//        public int code { get; set; }
//        public Description2 description { get; set; }
//    }

//    public class Description2
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class City
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Coordinates
//    {
//        public float latitude { get; set; }
//        public float longitude { get; set; }
//    }

//    public class Country
//    {
//        public string code { get; set; }
//        public Description3 description { get; set; }
//        public string isoCode { get; set; }
//        public State[] states { get; set; }
//    }

//    public class Description3
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class State
//    {
//        public string code { get; set; }
//        public string name { get; set; }
//    }

//    public class Description4
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Destination
//    {
//        public string code { get; set; }
//        public string countryCode { get; set; }
//        public Groupzone[] groupZones { get; set; }
//        public string isoCode { get; set; }
//        public Name1 name { get; set; }
//        public Zone[] zones { get; set; }
//    }

//    public class Name1
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Groupzone
//    {
//        public string groupZoneCode { get; set; }
//        public Name2 name { get; set; }
//        public int[] zones { get; set; }
//    }

//    public class Name2
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Zone
//    {
//        public Description5 description { get; set; }
//        public string name { get; set; }
//        public int zoneCode { get; set; }
//    }

//    public class Description5
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Name3
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class State1
//    {
//        public string code { get; set; }
//        public string name { get; set; }
//    }

//    public class Zone1
//    {
//        public Description6 description { get; set; }
//        public string name { get; set; }
//        public int zoneCode { get; set; }
//    }

//    public class Description6
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Board
//    {
//        public string code { get; set; }
//        public Description7 description { get; set; }
//        public string multiLingualCode { get; set; }
//    }

//    public class Description7
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Facility
//    {
//        public int ageFrom { get; set; }
//        public int ageTo { get; set; }
//        public int amount { get; set; }
//        public string applicationType { get; set; }
//        public string currency { get; set; }
//        public string dateFrom { get; set; }
//        public string dateTo { get; set; }
//        public Description8 description { get; set; }
//        public int distance { get; set; }
//        public int facilityCode { get; set; }
//        public int facilityGroupCode { get; set; }
//        public string facilityName { get; set; }
//        public bool indFee { get; set; }
//        public bool indLogic { get; set; }
//        public bool indYesOrNo { get; set; }
//        public int number { get; set; }
//        public int order { get; set; }
//        public string timeFrom { get; set; }
//        public string timeTo { get; set; }
//        public bool voucher { get; set; }
//    }

//    public class Description8
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Image
//    {
//        public string characteristicCode { get; set; }
//        public string imageTypeCode { get; set; }
//        public int order { get; set; }
//        public string path { get; set; }
//        public string roomCode { get; set; }
//        public string roomType { get; set; }
//        public Type type { get; set; }
//        public int visualOrder { get; set; }
//        public string PMSRoomCode { get; set; }
//    }

//    public class Type
//    {
//        public string code { get; set; }
//        public Description9 description { get; set; }
//    }

//    public class Description9
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Interestpoint
//    {
//        public int distance { get; set; }
//        public int facilityCode { get; set; }
//        public int facilityGroupCode { get; set; }
//        public bool fee { get; set; }
//        public int order { get; set; }
//        public string poiName { get; set; }
//    }

//    public class Issue
//    {
//        public bool alternative { get; set; }
//        public string dateFrom { get; set; }
//        public string dateTo { get; set; }
//        public Description10 description { get; set; }
//        public string issueCode { get; set; }
//        public string issueType { get; set; }
//        public int order { get; set; }
//    }

//    public class Description10
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Phone
//    {
//        public long phoneNumber { get; set; }
//        public string phoneType { get; set; }
//    }

//    public class Room
//    {
//        public string characteristicCode { get; set; }
//        public string description { get; set; }
//        public string roomCode { get; set; }
//        public Roomfacility[] roomFacilities { get; set; }
//        public Roomstay[] roomStays { get; set; }
//        public string roomType { get; set; }
//    }

//    public class Roomfacility
//    {
//        public Description11 description { get; set; }
//        public int facilityCode { get; set; }
//        public int facilityGroupCode { get; set; }
//        public bool indFee { get; set; }
//        public bool indLogic { get; set; }
//        public bool indYesOrNo { get; set; }
//        public int number { get; set; }
//        public int order { get; set; }
//        public bool voucher { get; set; }
//    }

//    public class Description11
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Roomstay
//    {
//        public string description { get; set; }
//        public int order { get; set; }
//        public Roomstayfacility[] roomStayFacilities { get; set; }
//        public string stayType { get; set; }
//    }

//    public class Roomstayfacility
//    {
//        public Description12 description { get; set; }
//        public int facilityCode { get; set; }
//        public int facilityGroupCode { get; set; }
//        public int number { get; set; }
//    }

//    public class Description12
//    {
//    }

//    public class Segment
//    {
//        public int code { get; set; }
//        public Description13 description { get; set; }
//    }

//    public class Description13
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Terminal
//    {
//        public Description14 description { get; set; }
//        public int distance { get; set; }
//        public Name4 name { get; set; }
//        public string terminalCode { get; set; }
//        public string terminalType { get; set; }
//    }

//    public class Description14
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Name4
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//    public class Wildcard
//    {
//        public string characteristicCode { get; set; }
//        public Hotelroomdescription hotelRoomDescription { get; set; }
//        public string roomCode { get; set; }
//        public string roomType { get; set; }
//    }

//    public class Hotelroomdescription
//    {
//        public string content { get; set; }
//        public string languageCode { get; set; }
//    }

//}