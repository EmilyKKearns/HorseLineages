using System;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Race
{
    [Key]
    public int RaceId { get; set; }
    public required string Name { get; set; }
    public required string Grade { get; set; }
    public required int Year { get; set; }
    public required string Turn { get; set; }
    public required string Season { get; set; }
    public required string Racecourse { get; set; }
    public required string TerrainType { get; set; }
    public required string Direction { get; set; }
    public required string Distance { get; set; }
    public required int LengthInMeters { get; set; }
}
