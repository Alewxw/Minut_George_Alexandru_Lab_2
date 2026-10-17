using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minut_George_Alexandru_Lab_2.Data;
using Minut_George_Alexandru_Lab_2.Models;

namespace Minut_George_Alexandru_Lab_2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Minut_George_Alexandru_Lab_2.Data.Minut_George_Alexandru_Lab_2Context _context;

        public DetailsModel(Minut_George_Alexandru_Lab_2.Data.Minut_George_Alexandru_Lab_2Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
