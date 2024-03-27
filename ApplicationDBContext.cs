using Microsoft.EntityFrameworkCore;
using GuideNeonEF.Models;
using dotenv.net;


namespace GuideNeonEF
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                DotEnv.Load();
                optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("DATABASE_URL"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .Property(a => a.CreatedAt)
                .HasDefaultValueSql("Now()");

            modelBuilder.Entity<Book>()
                .Property(b => b.CreatedAt)
                .HasDefaultValueSql("Now()");

            modelBuilder.Seed();
        }
        
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}