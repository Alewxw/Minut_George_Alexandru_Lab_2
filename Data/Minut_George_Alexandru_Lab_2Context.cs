using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Minut_George_Alexandru_Lab_2.Models;

namespace Minut_George_Alexandru_Lab_2.Data
{
    public class Minut_George_Alexandru_Lab_2Context : DbContext
    {
        public Minut_George_Alexandru_Lab_2Context (DbContextOptions<Minut_George_Alexandru_Lab_2Context> options)
            : base(options)
        {
        }

        public DbSet<Minut_George_Alexandru_Lab_2.Models.Book> Book { get; set; } = default!;
        public DbSet<Minut_George_Alexandru_Lab_2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
