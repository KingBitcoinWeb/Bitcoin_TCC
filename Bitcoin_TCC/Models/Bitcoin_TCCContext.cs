using Microsoft.EntityFrameworkCore;

namespace Bitcoin_TCC.Models
{
    public class Bitcoin_TCCContext : DbContext
    {

        public Bitcoin_TCCContext() : base ("name=Bitcoin_TCCContext")
            { 
           }

    public DbSet<ContatoKB> ContatoKB { get; set; }
}
}