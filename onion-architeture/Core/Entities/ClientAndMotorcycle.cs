using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace onion_architeture.Core.Entities
{
    public class ClientAndMotorcycle
    {
        
        [Key]
        public int ClientId { get; set; }

        [Key]
        public int MotorcycleId { get; set; }

        public Client Client { get; set; }
        public Motorcycle Motorcycle { get; set; }
    }
}
