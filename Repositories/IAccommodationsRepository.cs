using BeinHazmanimFinderAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeinHazmanimFinderAPI.Ripositories
{
    public interface IAccommodationsRepository
    {
        public Task<IEnumerable<Accommodation>> GetAllAsync();
        public Task<Accommodation?> GetByIdAsync(int id);
        public Task<Accommodation> CreateAsync(Accommodation accommodation);
        public Task<Accommodation?> UpdateAsync(int id, Accommodation accommodation);
        public Task<bool> DeleteAsync(int id);
        public Task<IEnumerable<Accommodation>> SreachAsync(string? city, decimal? maxPrice, bool? accessible);
        public Task<IEnumerable<string>> GetAccommodationTypesAsync();

    }
}
