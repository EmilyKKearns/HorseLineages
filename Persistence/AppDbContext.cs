using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Race> Races { get; set; }
    public required DbSet<HorseSnapshot> HorseSnapshots { get; set; }
}
