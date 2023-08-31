using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrappierIMDB.Models;

namespace CrappierIMDB.Data
{
    public class CrappierIMDBContext : DbContext
    {
        public CrappierIMDBContext (DbContextOptions<CrappierIMDBContext> options)
            : base(options)
        {
        }

        public DbSet<CrappierIMDB.Models.Movie> Movie { get; set; } = default!;
    }
}
