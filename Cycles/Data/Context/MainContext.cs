using Cycles.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Cycles.Data.Context;

public class MainContext : DbContext
{
    public DbSet<Property> Properties => Set<Property>();
    public DbSet<Car> Cars => Set<Car>();
    public DbSet<House> Houses => Set<House>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=.; Database=Test; Trusted_Connection=true; Encrypt=false";
        optionsBuilder.UseSqlServer(connectionString);
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information)
            .EnableSensitiveDataLogging();
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Property>()
            .HasOne(p => p.Car)
            .WithOne(c => c.Property)
            .HasForeignKey<Car>(c => c.PropertyId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();           
    }
}
