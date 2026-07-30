using BeinHazmanimFinderAPI.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BeinHazmanimFinderAPI.Models
{
    public class Accommodation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MaxLength(70, ErrorMessage = "The name must be up to 70 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "The Accommodation Type is Required")]
        public AccommodationType AccommodationType { get; set; }

        [Required(ErrorMessage = "The City is Required")]
        [MaxLength(40, ErrorMessage = "The city must be up to 40 characters.")]
        public string City { get; set; } = string.Empty;


        [Required(ErrorMessage = "The area is Required")]
        [MaxLength(50, ErrorMessage = "The area must be up to 50 characters.")]
        public string Area { get; set; } = string.Empty;


        [Required(ErrorMessage = "The Kashrut Authority is Required")]
        public KashrutAuthorityType KashrutAuthority { get; set; }

        [Required(ErrorMessage = "The PricePerNight is Required")]
        [Range(0, 10000, ErrorMessage = "The PricePerNight must be between 0-10000.")]
        public decimal PricePerNight { get; set; }

        [Required(ErrorMessage = "The MaximumGuests is Required")]
        [Range(1, 500, ErrorMessage = "The MaximumGuests must be between 1-500.")]
        public int MaximumGuests { get; set; }

        [Required(ErrorMessage = "The AvailableFrom  is Required")]
        public DateTime AvailableFrom { get; set; }

        [Required(ErrorMessage = "The IsAccessible is Required")]
        public bool IsAccessible { get; set; } = false;

        [Required(ErrorMessage = "The IsAbroad is Required")]
        public bool IsAbroad { get; set; } = false;

    }

}
