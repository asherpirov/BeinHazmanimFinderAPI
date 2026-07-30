using BeinHazmanimFinderAPI.Models;
using BeinHazmanimFinderAPI.Models.Enums;


namespace BeinHazmanimFinderAPI.Ripositories
{
    public class AccommodationsRepository : IAccommodationsRipository
    {
        private readonly List<Accommodation> _accommodations;
        private int _nextId;

        public AccommodationsRepository()
        {
            _nextId = 4;
            _accommodations = new()
            {
                new Accommodation
                {
                    Id = 1,
                    Name =  "King David Suites",
                    AccommodationType = AccommodationType.Hotel,
                    City = "Jerusalem",
                    Area = "City Center",
                    KashrutAuthority = KashrutAuthorityType.EidaCharedit,
                    PricePerNight = 950,
                    MaximumGuests = 4,
                    AvailableFrom = new DateTime(2026, 08, 01),
                    IsAccessible = true,
                    IsAbroad = false
                },
                new Accommodation
                {
                    Id = 2,
                    Name = "Ramat Shlomo Apartment",
                    AccommodationType = AccommodationType.VacationApartment,
                    City = "Jerusalem",
                    Area = "Ramat Shlomo",
                    KashrutAuthority = KashrutAuthorityType.EidaCharedit,
                    PricePerNight = 520,
                    MaximumGuests = 6,
                    AvailableFrom = new DateTime(2026, 08, 02),
                    IsAccessible = false,
                    IsAbroad = false
                },
                new Accommodation
                {
                    Id = 3,
                    Name = "Rabbi Akiva Guest House",
                    AccommodationType = AccommodationType.GuestHouse,
                    City = "Bnei Brak",
                    Area = "Rabbi Akiva",
                    KashrutAuthority = KashrutAuthorityType.RavLandau,
                    PricePerNight = 430,
                    MaximumGuests = 8,
                    AvailableFrom = new DateTime(2026, 08, 03),
                    IsAccessible = true,
                    IsAbroad = false
                }
            };

        }
        public async Task<IEnumerable<Accommodation>> GetAllAsync()
        {
            await Task.Delay(10);
            return _accommodations;
        }
        public async Task<Accommodation?> GetByIdAsync(int id)
        {
            await Task.Delay(10);
            return _accommodations.FirstOrDefault(a => a.Id == id);

        }
        public async Task<Accommodation> CreateAsync(Accommodation accommodation)
        {
            await Task.Delay(10);

            accommodation.Id = _nextId++;
            _accommodations.Add(accommodation);
            return accommodation;

        }

        public async Task<Accommodation?> UpdateAsync(int id, Accommodation updatedAccommodation)
        {
            await Task.Delay(10);

            var exsiting = _accommodations.FirstOrDefault(a => a.Id == id);

            if (exsiting == null)
            {
                return null;
            }

            exsiting.Name = updatedAccommodation.Name;
            exsiting.AccommodationType = updatedAccommodation.AccommodationType;
            exsiting.City = updatedAccommodation.City;
            exsiting.Area = updatedAccommodation.Area;
            exsiting.KashrutAuthority = updatedAccommodation.KashrutAuthority;
            exsiting.PricePerNight = updatedAccommodation.PricePerNight;
            exsiting.MaximumGuests = updatedAccommodation.MaximumGuests;
            exsiting.AvailableFrom = updatedAccommodation.AvailableFrom;
            exsiting.IsAccessible = updatedAccommodation.IsAccessible;
            exsiting.IsAbroad = updatedAccommodation.IsAbroad;

            return exsiting;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await Task.Delay(10);

            var acommodation = _accommodations.FirstOrDefault(a => a.Id == id);

            if (acommodation == null)
            {
                return false;
            }
            _accommodations.Remove(acommodation);
            return true;

        }


    }
}
