using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class LicznikiContext : DbContext
    {

        public LicznikiContext(DbContextOptions<LicznikiContext> options) : base(options)
        {
        }

        public DbSet<Liczniki> Liczniki { get; set; }
        public DbSet<LicznikDane> LicznikDane { get; set; }
        public DbSet<Budynek> Budynek { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Liczniki>().ToTable("Liczniki");
            modelBuilder.Entity<LicznikDane>().ToTable("LicznikDane");
            modelBuilder.Entity<Budynek>().ToTable("Budynek");
        }
    }
}