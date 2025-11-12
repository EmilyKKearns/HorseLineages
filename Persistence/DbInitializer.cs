using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Persistence;

public static class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        // grade pool used for aptitude letter grades (S highest .. G lowest)
        var gradePool = new[] { "S", "A", "B", "C", "D", "E", "F", "G" };
        if (!context.Races.Any())
        {
            var races = new List<Race>
            {
                new() {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Hanshin Juvenile Fillies",
                    Grade = "G1",
                    Year = 1,
                    Turn = "December 1",
                    Season = "Winter",
                    Racecourse = "Hanshin",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Mile",
                    LengthInMeters = 1600
                },
                new() {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Asahi Hai Futurity Stakes",
                    Grade = "G1",
                    Year = 1,
                    Turn = "December 1",
                    Season = "Winter",
                    Racecourse = "Hanshin",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Mile",
                    LengthInMeters = 1600
                },
                new() {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Hopeful Stakes",
                    Grade = "G1",
                    Year = 1,
                    Turn = "December 1",
                    Season = "Winter",
                    Racecourse = "Nakayama",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2000
                },
                new() {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Oka Sho",
                    Grade = "G1",
                    Year = 2,
                    Turn = "April 1",
                    Season = "Spring",
                    Racecourse = "Hanshin",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Mile",
                    LengthInMeters = 1600
                },
                new() {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Satsuki Sho",
                    Grade = "G1",
                    Year = 2,
                    Turn = "April 1",
                    Season = "Spring",
                    Racecourse = "Nakayama",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2000
                },
                new() {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Japanese Oaks",
                    Grade = "G1",
                    Year = 2,
                    Turn = "May 2",
                    Season = "Spring",
                    Racecourse = "Tokyo",
                    TerrainType = "Turf",
                    Direction = "Counterclockwise",
                    Distance = "Medium",
                    LengthInMeters = 2400
                },
                new() {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Tokyo Yushun (Japanese Derby)",
                    Grade = "G1",
                    Year = 2,
                    Turn = "May 2",
                    Season = "Spring",
                    Racecourse = "Tokyo",
                    TerrainType = "Turf",
                    Direction = "Counterclockwise",
                    Distance = "Medium",
                    LengthInMeters = 2400
                },
                new() {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Yasuda Kinen",
                    Grade = "G1",
                    Year = 2,
                    Turn = "June 1",
                    Season = "Spring",
                    Racecourse = "Tokyo",
                    TerrainType = "Turf",
                    Direction = "Counterclockwise",
                    Distance = "Mile",
                    LengthInMeters = 1600
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Takarazuka Kinen",
                    Grade = "G1",
                    Year = 2,
                    Turn = "June 2",
                    Season = "Spring",
                    Racecourse = "Hanshin",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2200
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Japan Dirt Derby",
                    Grade = "G1",
                    Year = 2,
                    Turn = "July 1",
                    Season = "Summer",
                    Racecourse = "Oi",
                    TerrainType = "Dirt",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2000
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Sprinters Stakes",
                    Grade = "G1",
                    Year = 2,
                    Turn = "September 2",
                    Season = "Fall",
                    Racecourse = "Nakayama",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Sprint",
                    LengthInMeters = 1200
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Kobe Shimbun Hai",
                    Grade = "G2",
                    Year = 2,
                    Turn = "September 2",
                    Season = "Fall",
                    Racecourse = "Hanshin",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2400
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Shuka Sho",
                    Grade = "G1",
                    Year = 2,
                    Turn = "October 2",
                    Season = "Fall",
                    Racecourse = "Kyoto",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2000
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Kikuka Sho",
                    Grade = "G1",
                    Year = 2,
                    Turn = "October 2",
                    Season = "Fall",
                    Racecourse = "Kyoto",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Long",
                    LengthInMeters = 3000
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Tenno Sho (Autumn)",
                    Grade = "G1",
                    Year = 2,
                    Turn = "October 2",
                    Season = "Fall",
                    Racecourse = "Tokyo",
                    TerrainType = "Turf",
                    Direction = "Counterclockwise",
                    Distance = "Medium",
                    LengthInMeters = 2000
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Queen Elizabeth II Cup",
                    Grade = "G1",
                    Year = 2,
                    Turn = "November 1",
                    Season = "Fall",
                    Racecourse = "Kyoto",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2200
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "JBC Classic",
                    Grade = "G1",
                    Year = 2,
                    Turn = "November 1",
                    Season = "Fall",
                    Racecourse = "Oi",
                    TerrainType = "Dirt",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2000
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "JBC Ladies' Classic",
                    Grade = "G1",
                    Year = 2,
                    Turn = "November 1",
                    Season = "Fall",
                    Racecourse = "Oi",
                    TerrainType = "Dirt",
                    Direction = "Clockwise",
                    Distance = "Mile",
                    LengthInMeters = 1800
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "JBC Sprint",
                    Grade = "G1",
                    Year = 2,
                    Turn = "November 1",
                    Season = "Fall",
                    Racecourse = "Oi",
                    TerrainType = "Dirt",
                    Direction = "Clockwise",
                    Distance = "Sprint",
                    LengthInMeters = 1200
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Japan Cup",
                    Grade = "G1",
                    Year = 2,
                    Turn = "November 2",
                    Season = "Fall",
                    Racecourse = "Tokyo",
                    TerrainType = "Turf",
                    Direction = "Counterclockwise",
                    Distance = "Medium",
                    LengthInMeters = 2400
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Mile Championship",
                    Grade = "G1",
                    Year = 2,
                    Turn = "November 2",
                    Season = "Fall",
                    Racecourse = "Kyoto",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Mile",
                    LengthInMeters = 1600
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Champions Cup",
                    Grade = "G1",
                    Year = 2,
                    Turn = "December 1",
                    Season = "Winter",
                    Racecourse = "Chukyo",
                    TerrainType = "Dirt",
                    Direction = "Counterclockwise",
                    Distance = "Mile",
                    LengthInMeters = 1800
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Arima Kinen",
                    Grade = "G1",
                    Year = 2,
                    Turn = "December 2",
                    Season = "Winter",
                    Racecourse = "Nakayama",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2500
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Tokyo Daishoten",
                    Grade = "G1",
                    Year = 2,
                    Turn = "December 2",
                    Season = "Winter",
                    Racecourse = "Oi",
                    TerrainType = "Dirt",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2000
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "February Stakes",
                    Grade = "G1",
                    Year = 3,
                    Turn = "February 2",
                    Season = "Winter",
                    Racecourse = "Tokyo",
                    TerrainType = "Dirt",
                    Direction = "Counterclockwise",
                    Distance = "Mile",
                    LengthInMeters = 1600
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Osaka Hai",
                    Grade = "G1",
                    Year = 3,
                    Turn = "March 2",
                    Season = "Spring",
                    Racecourse = "Hanshin",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2000
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Takamatsunomiya Kinen",
                    Grade = "G1",
                    Year = 3,
                    Turn = "March 2",
                    Season = "Spring",
                    Racecourse = "Chukyo",
                    TerrainType = "Turf",
                    Direction = "Counterclockwise",
                    Distance = "Sprint",
                    LengthInMeters = 1200
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Tenno Sho (Spring)",
                    Grade = "G1",
                    Year = 3,
                    Turn = "April 2",
                    Season = "Spring",
                    Racecourse = "Kyoto",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Long",
                    LengthInMeters = 3200
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Victoria Mile",
                    Grade = "G1",
                    Year = 3,
                    Turn = "May 1",
                    Season = "Spring",
                    Racecourse = "Tokyo",
                    TerrainType = "Turf",
                    Direction = "Counterclockwise",
                    Distance = "Mile",
                    LengthInMeters = 1600
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Yasuda Kinen",
                    Grade = "G1",
                    Year = 3,
                    Turn = "June 1",
                    Season = "Spring",
                    Racecourse = "Tokyo",
                    TerrainType = "Turf",
                    Direction = "Counterclockwise",
                    Distance = "Mile",
                    LengthInMeters = 1600
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Takarazuka Kinen",
                    Grade = "G1",
                    Year = 3,
                    Turn = "June 2",
                    Season = "Spring",
                    Racecourse = "Hanshin",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2200
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Teio Sho",
                    Grade = "G1",
                    Year = 3,
                    Turn = "June 2",
                    Season = "Spring",
                    Racecourse = "Oi",
                    TerrainType = "Dirt",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2000
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Sprinters Stakes",
                    Grade = "G1",
                    Year = 3,
                    Turn = "September 2",
                    Season = "Fall",
                    Racecourse = "Nakayama",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Sprint",
                    LengthInMeters = 1200
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Tenno Sho (Autumn)",
                    Grade = "G1",
                    Year = 3,
                    Turn = "October 2",
                    Season = "Fall",
                    Racecourse = "Tokyo",
                    TerrainType = "Turf",
                    Direction = "Counterclockwise",
                    Distance = "Medium",
                    LengthInMeters = 2000
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Queen Elizabeth II Cup",
                    Grade = "G1",
                    Year = 3,
                    Turn = "November 1",
                    Season = "Fall",
                    Racecourse = "Kyoto",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2200
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "JBC Classic",
                    Grade = "G1",
                    Year = 3,
                    Turn = "November 1",
                    Season = "Fall",
                    Racecourse = "Oi",
                    TerrainType = "Dirt",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2000
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "JBC Ladies' Classic",
                    Grade = "G1",
                    Year = 3,
                    Turn = "November 1",
                    Season = "Fall",
                    Racecourse = "Oi",
                    TerrainType = "Dirt",
                    Direction = "Clockwise",
                    Distance = "Mile",
                    LengthInMeters = 1800
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "JBC Sprint",
                    Grade = "G1",
                    Year = 3,
                    Turn = "November 1",
                    Season = "Fall",
                    Racecourse = "Oi",
                    TerrainType = "Dirt",
                    Direction = "Clockwise",
                    Distance = "Sprint",
                    LengthInMeters = 1200
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Japan Cup",
                    Grade = "G1",
                    Year = 3,
                    Turn = "November 2",
                    Season = "Fall",
                    Racecourse = "Tokyo",
                    TerrainType = "Turf",
                    Direction = "Counterclockwise",
                    Distance = "Medium",
                    LengthInMeters = 2400
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Mile Championship",
                    Grade = "G1",
                    Year = 3,
                    Turn = "November 2",
                    Season = "Fall",
                    Racecourse = "Kyoto",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Mile",
                    LengthInMeters = 1600
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Champions Cup",
                    Grade = "G1",
                    Year = 3,
                    Turn = "December 1",
                    Season = "Winter",
                    Racecourse = "Chukyo",
                    TerrainType = "Dirt",
                    Direction = "Counterclockwise",
                    Distance = "Mile",
                    LengthInMeters = 1800
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Arima Kinen",
                    Grade = "G1",
                    Year = 3,
                    Turn = "December 2",
                    Season = "Winter",
                    Racecourse = "Nakayama",
                    TerrainType = "Turf",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2500
                },
                new()
                {
                    HorsesRequiredFor = new List<Horse>(),
                    Name = "Tokyo Daishoten",
                    Grade = "G1",
                    Year = 3,
                    Turn = "December 2",
                    Season = "Winter",
                    Racecourse = "Oi",
                    TerrainType = "Dirt",
                    Direction = "Clockwise",
                    Distance = "Medium",
                    LengthInMeters = 2000
                },
            };
            
            
            // Build a minimal pool of seed horses and assign them to races.
            // Rule: no horse may be assigned to more than one Race that shares the same Turn.
            // reuse gradePool declared earlier for aptitude letter grades
            var horses = new List<Horse>();
            var horseTurns = new List<HashSet<string>>();

            foreach (var race in races)
            {
                // try to find an existing horse that doesn't already have this Turn
                var idx = horseTurns.FindIndex(ht => !ht.Contains(race.Turn));
                if (idx >= 0)
                {
                    // reuse horse
                    var h = horses[idx];
                    h.CareerRaces.Add(race);
                    horseTurns[idx].Add(race.Turn);
                    race.HorsesRequiredFor = new List<Horse> { h };
                }
                else
                {
                    // create a new horse
                    var i = horses.Count;
                    var h = new Horse
                    {
                        CareerRaces = new List<Race> { race },
                        Name = $"Seed Horse {i + 1}",
                        TurfAptitude = gradePool[i % gradePool.Length],
                        DirtAptitude = gradePool[(i + 1) % gradePool.Length],
                        SprintAptitude = gradePool[(i + 2) % gradePool.Length],
                        MileAptitude = gradePool[(i + 3) % gradePool.Length],
                        MediumAptitude = gradePool[(i + 4) % gradePool.Length],
                        LongAptitude = gradePool[(i + 5) % gradePool.Length],
                        FrontRunnerAptitude = gradePool[(i + 6) % gradePool.Length],
                        PaceChaserAptitude = gradePool[(i + 7) % gradePool.Length],
                        LateSurgerAptitude = gradePool[i % gradePool.Length],
                        EndCloserAptitude = gradePool[(i + 1) % gradePool.Length]
                    };

                    horses.Add(h);
                    horseTurns.Add(new HashSet<string> { race.Turn });
                    race.HorsesRequiredFor = new List<Horse> { h };
                }
            }

            // Persist horses and races. EF Core will handle the many-to-many join table.
            context.Horses.AddRange(horses);
            context.Races.AddRange(races);
            await context.SaveChangesAsync();
        }

        if (context.HorseSnapshots.Any()) return;

        var raceList = context.Races.ToList();

    // reuse gradePool declared earlier for aptitude letter grades

        var horseSnapshots = new List<HorseSnapshot>
        {
            new() {
                HorseId = 1,
                RacesWon = raceList
                            .Where(r => r.Name == "Tokyo Yushun (Japanese Derby)" || r.Name == "Arima Kinen")
                            .ToList(),
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
                TurfAptitude = gradePool[0],
                DirtAptitude = gradePool[2],
                SprintAptitude = gradePool[1],
                MileAptitude = gradePool[0],
                MediumAptitude = gradePool[3],
                LongAptitude = gradePool[4],
                FrontRunnerAptitude = gradePool[0],
                PaceChaserAptitude = gradePool[1],
                LateSurgerAptitude = gradePool[2],
                EndCloserAptitude = gradePool[3]
            },
            new() {
                HorseId = 2,
                RacesWon = raceList
                            .Where(r => r.Name == "Oka Sho" || r.Name == "Yasuda Kinen")
                            .ToList(),
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
                TurfAptitude = gradePool[1],
                DirtAptitude = gradePool[0],
                SprintAptitude = gradePool[3],
                MileAptitude = gradePool[2],
                MediumAptitude = gradePool[2],
                LongAptitude = gradePool[4],
                FrontRunnerAptitude = gradePool[5],
                PaceChaserAptitude = gradePool[1],
                LateSurgerAptitude = gradePool[3],
                EndCloserAptitude = gradePool[2]
            },
            new() {
                HorseId = 3,
                RacesWon = raceList.Where(r => r.Name == "Kikuka Sho")
                                   .ToList(),
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
                TurfAptitude = gradePool[2],
                DirtAptitude = gradePool[4],
                SprintAptitude = gradePool[5],
                MileAptitude = gradePool[3],
                MediumAptitude = gradePool[4],
                LongAptitude = gradePool[6],
                FrontRunnerAptitude = gradePool[3],
                PaceChaserAptitude = gradePool[2],
                LateSurgerAptitude = gradePool[4],
                EndCloserAptitude = gradePool[5]
            },

        };

        context.HorseSnapshots.AddRange(horseSnapshots);
        await context.SaveChangesAsync();
    }
}
