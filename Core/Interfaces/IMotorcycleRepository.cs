using System.Collections.Generic;
using SklepMotorowy.Core.Entities;

namespace SklepMotorowy.Core.Interfaces
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