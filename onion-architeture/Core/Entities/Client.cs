using System.ComponentModel.DataAnnotations;

namespace onion_architeture.Core.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public string Surname { get; set; }
        [Required]

        public int Age { get; set; }
        [Required]

        public string DrivingLicence { get; set; }

        public ICollection<ClientAndMotorcycle> ClientAndMotorcycles { get; set; }
    }
}