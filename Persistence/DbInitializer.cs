using System;
using Domain;

namespace Persistence;

public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (!context.Races.Any())
        {
            var races = new List<Race>
            {
                new() {
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
            
            context.Races.AddRange(races);
            await context.SaveChangesAsync();
        }

        if (context.HorseSnapshots.Any()) return;

        var raceList = context.Races.ToList();
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
            },

        };

        context.HorseSnapshots.AddRange(horseSnapshots);
        await context.SaveChangesAsync();
    }
}
