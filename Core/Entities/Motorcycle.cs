using onion_architeture.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace SklepMotorowy.Core.Entities
{
    public class Motorcycle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]

        public string Model { get; set; }
        [Required]

        public int Price { get; set; }

        public ICollection<ClientAndMotorcycle> ClientAndMotorcycles { get; set; }

        public ICollection<Insurance> Insurances { get; set; }

    }
}