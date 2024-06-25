using System;
using System.ComponentModel.DataAnnotations;

namespace onion_architeture.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Podaj swoje imię")]
        [StringLength(maximumLength: 50, ErrorMessage = "Imię za długie maksymalna ilość znaków 50 ")]
        [Display(Name = "Imię")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Zły adres email")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Telefon")]
        [Phone]
        public string Phone { get; set; } = string.Empty;

        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        public DateTime? Birth { get; set; }

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }
    }
}
