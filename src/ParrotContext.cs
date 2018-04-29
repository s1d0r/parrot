using Microsoft.EntityFrameworkCore;

namespace parrot
{
    class ParrotContext : DbContext
    {
        public DbSet<ParrotKnowledge> ParrotKnowledge { get; set; }
        public ParrotContext(DbContextOptions<ParrotContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}