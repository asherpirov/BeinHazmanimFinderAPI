//using BeinHazmanimFinderAPI.Models;
//using BeinHazmanimFinderAPI.Ripositories;

//namespace BeinHazmanimFinderAPI.Services
//{
//    public class AccommodationsService : IAccommodationsService
//    {
//        private readonly IAccommodationsRepository _accommodationsRepository;
//        private readonly IActivityPlacesRepository _activityPlaceRepository;

//        public AccommodationsService(IAccommodationsRepository accommodationsRepository,
//           IActivityPlacesRepository activityPlaceRepository)
//        {
//            _accommodationsRepository = accommodationsRepository;
//            _activityPlaceRepository = activityPlaceRepository;
//        }

//        public async Task<IEnumerable<AccommodationActivitePlaceDTO>> GetAccNearByActiveAsync(string? city, int minimumActivities)
//        {
//            var accommodations = await _accommodationsRepository.GetAllAsync();
//            var activityPlaces = await _activityPlaceRepository.GetAllAsync();

//            var query = accommodations.AsQueryable();

//            if (!string.IsNullOrWhiteSpace(city))
//            {
//                query = query.Where(a => a.City.Equals(city, StringComparison.OrdinalIgnoreCase));

//            }
            
            
//        }

//    }
//}
