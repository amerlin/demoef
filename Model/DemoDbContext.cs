using ef_demo.Model;
using Microsoft.EntityFrameworkCore;

public class DemoDbContext : DbContext
{
    public DemoDbContext(DbContextOptions<DemoDbContext> options)
        : base(options)
    { 
        
    }

    public DbSet<Students> Students { get; set; }
    public DbSet<City> Cities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<City>().ToTable("Citta");

        modelBuilder.Entity<City>()
                .Property(s => s.CityId)
                .HasColumnName("Id");

        modelBuilder.Entity<City>()
                .Property(s => s.Edicole)
                .HasDefaultValue(0)
                .IsRequired();

    }

}