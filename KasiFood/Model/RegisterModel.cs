using System.ComponentModel.DataAnnotations;

namespace KasiFood.Model
{
    public class RegisterModel
    {
        [Key]
        public Guid CustomerGuid { get; set; }

        [Required (ErrorMessage = "Name is required!")]
        public string? CustomerName { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string? EmailAddress { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Password must be at least 8 characters long.", MinimumLength = 8)]
        public string? Password { get; set; }
    }
}
