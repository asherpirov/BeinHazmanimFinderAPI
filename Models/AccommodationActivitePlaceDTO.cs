namespace BeinHazmanimFinderAPI.Models
{
    public class AccommodationActivitePlaceDTO
    {
        public int AccommodationId { get; set; }
        public string AccommodationName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public int NearbyActivityCount { get; set; }

    }
}
