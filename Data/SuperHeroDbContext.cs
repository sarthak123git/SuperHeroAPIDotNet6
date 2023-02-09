using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Model;

namespace SuperHeroAPI.Data
{
    public class SuperHeroDbContext : DbContext
    {
        public SuperHeroDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
