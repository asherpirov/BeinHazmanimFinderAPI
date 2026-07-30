using BeinHazmanimFinderAPI.Models;

namespace BeinHazmanimFinderAPI.Ripositories
{
    public interface IAccommodationsRipository
    {
        public Task<IEnumerable<Accommodation>> GetAllAsync();
        public Task<Accommodation?> GetByIdAsync(int id);
        public Task<Accommodation> CreateAsync(Accommodation accommodation);
        public Task<Accommodation?> UpdateAsync(int id, Accommodation accommodation);
        public Task<bool> DeleteAsync(int id);

    }
}
