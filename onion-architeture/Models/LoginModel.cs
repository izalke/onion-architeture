using System.ComponentModel.DataAnnotations;

namespace onion_architecture.Models
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }


}