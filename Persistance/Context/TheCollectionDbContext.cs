using Microsoft.EntityFrameworkCore;
using TheCollection.Models;

namespace TheCollection.Persistance.Context
{
    public class TheCollectionDbContext : DbContext
    {
        public TheCollectionDbContext(DbContextOptions<TheCollectionDbContext> options) : base(options) {}

        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Monsters> Monsters {get; set; }
        
    }
}