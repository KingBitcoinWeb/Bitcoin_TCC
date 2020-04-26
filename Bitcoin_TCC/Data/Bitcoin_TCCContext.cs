using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

//    "Bitcoin_TCCContext": "Server=tcp:kingbitcoindb.database.windows.net,1433;Initial Catalog=kinggbitcoindb;Persist Security Info=False;User ID=KingBitcoinWeb;Password=BitcoinKing@3000;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"

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
