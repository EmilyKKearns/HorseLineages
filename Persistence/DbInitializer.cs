using System;
using Domain;

namespace Persistence;

public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (context.HorseSnapshots.Any()) return;

        var horseSnapshots = new List<HorseSnapshot>
        {
            new() {
                HorseId = 1,
                Rank = "A+",
                Score = 12500,
                StarLevel = 4,
                PotentialLevel = 5,
                UniqueSkillLevel = 5,
                Speed = 1200,
                Stamina = 800,
                Power = 1200,
                Guts = 400,
                Wit = 500,
                IsGuest = false,
            },
            new() {
                HorseId = 2,
                Rank = "B",
                Score = 9500,
                StarLevel = 3,
                PotentialLevel = 1,
                UniqueSkillLevel = 4,
                Speed = 750,
                Stamina = 400,
                Power = 600,
                Guts = 250,
                Wit = 400,
                IsGuest = false,
            },
            new() {
                HorseId = 3,
                Rank = "C+",
                Score = 8400,
                StarLevel = 3,
                PotentialLevel = 1,
                UniqueSkillLevel = 4,
                Speed = 550,
                Stamina = 300,
                Power = 600,
                Guts = 250,
                Wit = 300,
                IsGuest = false,
            },

        };

        context.HorseSnapshots.AddRange(horseSnapshots);
        await context.SaveChangesAsync();
    }
}
