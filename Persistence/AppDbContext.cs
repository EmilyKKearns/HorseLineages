using System;
using System.Globalization;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Persistence;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Race> Races { get; set; }
    public required DbSet<Horse> Horses { get; set; }
    public required DbSet<HorseSnapshot> HorseSnapshots { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Horse>()
            .HasMany(h => h.CareerRaces)
            .WithMany();

        modelBuilder.Entity<HorseSnapshot>()
            .HasMany(hs => hs.RacesWon)
            .WithMany();
    }

}
