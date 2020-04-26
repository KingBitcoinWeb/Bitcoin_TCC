using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bitcoin_TCC.Models
{
    public class Bitcoin_TCCContext : DbContext
    {
        public Bitcoin_TCCContext (DbContextOptions<Bitcoin_TCCContext> options)
            : base(options)
        {
        }

        public DbSet<Bitcoin_TCC.Models.ContatoKB> ContatoKB { get; set; }
    }
}
