using System.Collections.Generic;
using onion_architeture.Core.Entities;

namespace onion_architeture.Core.Interfaces
{
    public interface IMotorcycleRepository
    {
        IEnumerable<Motorcycle> GetAllMotorcycles();
        Motorcycle GetMotorcycleById(int id);
        void AddMotorcycle(Motorcycle motorcycle);
        void UpdateMotorcycle(Motorcycle motorcycle);
        void DeleteMotorcycle(int id);
    }
}