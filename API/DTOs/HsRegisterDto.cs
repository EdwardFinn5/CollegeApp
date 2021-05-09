using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class HsRegisterDto
    {
        [Required]
        public string ColUserName { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
        public string ColUserType { get; set; } = "ColLead";

    }
}