using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using onion_architeture.Core.Entities;
using onion_architeture.Infrastructure.Data;

namespace onion_architeture.Pages.UserAdmiistrationPages
{
    public class DetailsUserMotorModel : PageModel
    {
        private readonly onion_architeture.Infrastructure.Data.ApplicationDbContext _context;

        public DetailsUserMotorModel(onion_architeture.Infrastructure.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public ClientAndMotorcycle ClientAndMotorcycle { get; set; } = default!;

        public IList<Motorcycle> Motorcycle { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return RedirectToPage("./Userlist");
            }

            var clientandmotorcycle = await _context.ClientMotorcycles.FirstOrDefaultAsync(m => m.ClientId == id);
            if (clientandmotorcycle == null)
            {
                return RedirectToPage("./Userlist");
            }
            else
            {
                ClientAndMotorcycle = clientandmotorcycle;
            }
            return Page();
        }
    }
}
