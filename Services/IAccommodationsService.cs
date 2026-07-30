using BeinHazmanimFinderAPI.Models;

namespace BeinHazmanimFinderAPI.Services
{
    public interface IAccommodationsService
    {
        public Task<IEnumerable<AccommodationActivitePlaceDTO>>
            GetAccNearByActiveAsync(string? city, int minimumActivities);
    }
}



