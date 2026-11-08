using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minut_George_Alexandru_Lab_2.Data;
using Minut_George_Alexandru_Lab_2.Models;

namespace Minut_George_Alexandru_Lab_2.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly Minut_George_Alexandru_Lab_2.Data.Minut_George_Alexandru_Lab_2Context _context;

        public IndexModel(Minut_George_Alexandru_Lab_2.Data.Minut_George_Alexandru_Lab_2Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Member = await _context.Member.ToListAsync();
        }
    }
}
