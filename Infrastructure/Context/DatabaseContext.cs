using Microsoft.EntityFrameworkCore;
using WebApplication.Core.Domain;

namespace WebApplication.Infrastructure.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PositionType> PositionTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Portfolio>().HasKey(pk => new { pk.ISINCode, pk.Date });

            modelBuilder.Entity<Portfolio>()
                .Property(sample => sample.ISINCode)
                .HasMaxLength(12);

            modelBuilder.Entity<Portfolio>()
                .Property(sample => sample.Date)
                .HasColumnType("date");

            modelBuilder.Entity<Portfolio>()
                .Property(sample => sample.Currency)
                .HasColumnType("char(3)");
        }
    }
}
