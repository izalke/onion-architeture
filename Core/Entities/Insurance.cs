using SklepMotorowy.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace onion_architeture.Core.Entities
{
    public class Insurance
    {
        [Key]
        public int InsuranceNumber { get; set; }

        [Required]
        public int MotorcycleId { get; set; }
        public Motorcycle Motorcycle { get; set; }

        [Required]
        public int InsuranceCost { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
    }
}
