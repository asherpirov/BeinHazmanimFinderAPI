using BeinHazmanimFinderAPI.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BeinHazmanimFinderAPI.Models
{
    public class ActivityPlace
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MaxLength(70, ErrorMessage = "The name must be up to 70 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "The Category is Required")]
        public CategoryType Category { get; set; }

        [Required(ErrorMessage = "The City is Required")]
        [MaxLength(40, ErrorMessage = "The city must be up to 40 characters.")]
        public string City { get; set; } = string.Empty;


        [Required(ErrorMessage = "The area is Required")]
        [MaxLength(50, ErrorMessage = "The area must be up to 50 characters.")]
        public string Area { get; set; } = string.Empty;

        [Required(ErrorMessage = "The TargetAudience is Required")]
        public TargetAudienceType TargetAudience { get; set; }

        [Required(ErrorMessage = "The PricePerPerson is Required")]
        [Range(0, 1000, ErrorMessage = "The PricePerPerson must be between 0-1000.")]
        public decimal PricePerPerson { get; set; }

        [Required(ErrorMessage = "The MinimumAge is Required")]
        [Range(0, 18, ErrorMessage = "The MinimumAge must be between 0-18.")]
        public int MinimumAge { get; set; }

        [Required(ErrorMessage = "The AvailableDate is Required")]
        public DateTime AvailableDate { get; set; }

        [Required(ErrorMessage = "The IsAccessible is Required")]
        public bool IsAccessible { get; set; } = false;

        [Required(ErrorMessage = "The RequiresKashrut is Required")]
        public bool RequiresKashrut { get; set; } = false;

        [MaxLength(50, ErrorMessage = "The KashrutAuthority must be up to 50 characters.")]
        public KashrutAuthorityType? KashrutAuthority { get; set; }
    }
}
