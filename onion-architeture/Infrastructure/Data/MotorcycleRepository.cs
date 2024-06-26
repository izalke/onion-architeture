using System.Collections.Generic;
using System.Linq;
using onion_architeture.Core.Entities;
using onion_architeture.Core.Interfaces;

namespace onion_architeture.Infrastructure.Data
{
    public class MotorcycleRepository : IMotorcycleRepository
    {
        private readonly ApplicationDbContext _context;

        public MotorcycleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Motorcycle> GetAllMotorcycles()
        {
            return _context.Motorcycles.ToList();
        }

        public Motorcycle GetMotorcycleById(int id)
        {
            return _context.Motorcycles.Find(id);
        }

        public void AddMotorcycle(Motorcycle motorcycle)
        {
            _context.Motorcycles.Add(motorcycle);
            _context.SaveChanges();
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            _context.Motorcycles.Update(motorcycle);
            _context.SaveChanges();
        }

        public void DeleteMotorcycle(int id)
        {
            var motorcycle = _context.Motorcycles.Find(id);
            if (motorcycle != null)
            {
                _context.Motorcycles.Remove(motorcycle);
                _context.SaveChanges();
            }
        }
    }
}