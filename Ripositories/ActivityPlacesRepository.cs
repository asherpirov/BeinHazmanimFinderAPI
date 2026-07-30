using BeinHazmanimFinderAPI.Models;
using BeinHazmanimFinderAPI.Models.Enums;


namespace BeinHazmanimFinderAPI.Ripositories
{
    public class ActivityPlacesRepository : IActivityPlacesRepository
    {
        private readonly List<ActivityPlace> _activityPlaces;
        private int _nextId;

        public ActivityPlacesRepository()
        {
            _nextId = 4;

            _activityPlaces = new()
            {
                new ActivityPlace
                {
                    Id = 1,
                    Name = "Cafe Rimon",
                    Category = CategoryType.Restaurant,
                    City = "Jerusalem",
                    Area = "City Center",
                    TargetAudience = TargetAudienceType.Families,
                    PricePerPerson = 90,
                    MinimumAge = 0,
                    AvailableDate = new DateTime(2026, 08, 01),
                    IsAccessible = true,
                    RequiresKashrut = true,
                    KashrutAuthority = KashrutAuthorityType.EidaCharedit
                },
                new ActivityPlace
                {
                    Id = 2,
                    Name = "Meat Grill House",
                    Category = CategoryType.Restaurant,
                    City = "Bnei Brak",
                    Area = "Rabbi Akiva",
                    TargetAudience = TargetAudienceType.Adults,
                    PricePerPerson = 140,
                    MinimumAge = 0,
                    AvailableDate = new DateTime(2026, 08, 02),
                    IsAccessible = false,
                    RequiresKashrut = true,
                    KashrutAuthority = KashrutAuthorityType.RavLandau
                },
                new ActivityPlace
                {
                    Id = 3,
                    Name = "Ein Gedi Nature Trail",
                    Category = CategoryType.NatureTrail,
                    City = "Ein Gedi",
                    Area = "Dead Sea Basin",
                    TargetAudience = TargetAudienceType.Families,
                    PricePerPerson = 45,
                    MinimumAge = 0,
                    AvailableDate = new DateTime(2026, 08, 03),
                    IsAccessible = false,
                    RequiresKashrut = false,
                }
          
            };


        }
        public async Task<IEnumerable<ActivityPlace>> GetAllAsync()
        {
            await Task.Delay(10);
            return _activityPlaces;
        }

        public async Task<ActivityPlace?> GetByIdAsync(int id)
        {
            await Task.Delay(10);
            return _activityPlaces.FirstOrDefault(a => a.Id == id);
        }

        public async Task<ActivityPlace> CreateAsync(ActivityPlace activityPlace)
        {
            await Task.Delay(10);

            activityPlace.Id = _nextId++;
            _activityPlaces.Add(activityPlace);
            return activityPlace;
        }

        public async Task<ActivityPlace?> UpdateAsync(int id, ActivityPlace updatedActivityPlace)
        {
            await Task.Delay(10);

            var exsiting = _activityPlaces.FirstOrDefault(a => a.Id == id);

            if (exsiting == null)
            {
                return null;
            }

            exsiting.Name = updatedActivityPlace.Name;
            exsiting.Category = updatedActivityPlace.Category;
            exsiting.City = updatedActivityPlace.City;
            exsiting.Area = updatedActivityPlace.Area;
            exsiting.TargetAudience = updatedActivityPlace.TargetAudience;
            exsiting.PricePerPerson = updatedActivityPlace.PricePerPerson;
            exsiting.MinimumAge = updatedActivityPlace.MinimumAge;
            exsiting.AvailableDate= updatedActivityPlace.AvailableDate;
            exsiting.IsAccessible = updatedActivityPlace.IsAccessible;
            exsiting.KashrutAuthority = updatedActivityPlace.KashrutAuthority;

            return exsiting;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await Task.Delay(10);

            var activityPlace = _activityPlaces.FirstOrDefault(a => a.Id == id);

            if (activityPlace == null)
            {
                return false;
            }
            _activityPlaces.Remove(activityPlace);
            return true;

        }

    }
}
