using System.ComponentModel.DataAnnotations;

namespace KasiFood.Model
{
    public class Address
    {
        [Key]
        public Guid AddressGuid { get; set; }

        [Required]
        public string? StreetName { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? Province { get; set; }

        [Required]
        public int ZipCode { get; set; }
    }
}
