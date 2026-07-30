using BeinHazmanimFinderAPI.Models;

namespace BeinHazmanimFinderAPI.Ripositories
{
    public interface IActivityPlacesRepository
    {
        public Task<IEnumerable<ActivityPlace>> GetAllAsync();
        public Task<ActivityPlace?> GetByIdAsync(int id);
        public Task<ActivityPlace> CreateAsync(ActivityPlace activityPlace);
        public Task<ActivityPlace?> UpdateAsync(int id, ActivityPlace activityPlace);
        public Task<bool> DeleteAsync(int id);
        public Task<IEnumerable<ActivityPlace>> SearchAsync(string? category, string? city, decimal? maxPrice, string? audience);


    }
}
