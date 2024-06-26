using Microsoft.AspNetCore.Mvc;
using onion_architeture.Core.Entities;
using onion_architeture.Core.Interfaces;

namespace onion_architeture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorcyclesController : ControllerBase
    {
        private readonly IMotorcycleRepository _motorcycleRepository;

        public MotorcyclesController(IMotorcycleRepository motorcycleRepository)
        {
            _motorcycleRepository = motorcycleRepository;
        }

        [HttpGet]
        public IActionResult GetAllMotorcycles()
        {
            var motorcycles = _motorcycleRepository.GetAllMotorcycles();
            return Ok(motorcycles);
        }

        [HttpGet("{id}")]
        public IActionResult GetMotorcycleById(int id)
        {
            var motorcycle = _motorcycleRepository.GetMotorcycleById(id);
            if (motorcycle == null)
            {
                return NotFound();
            }
            return Ok(motorcycle);
        }

        [HttpPost]
        public IActionResult AddMotorcycle(Motorcycle motorcycle)
        {
            _motorcycleRepository.AddMotorcycle(motorcycle);
            return CreatedAtAction(nameof(GetMotorcycleById), new { id = motorcycle.Id }, motorcycle);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMotorcycle(int id, Motorcycle motorcycle)
        {
            if (id != motorcycle.Id)
            {
                return BadRequest();
            }

            _motorcycleRepository.UpdateMotorcycle(motorcycle);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMotorcycle(int id)
        {
            _motorcycleRepository.DeleteMotorcycle(id);
            return NoContent();
        }
    }
}