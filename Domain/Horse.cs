using System;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Horse
{
    [Key]
    public int HorseId { get; set; }
    public required string Name { get; set; }
    // TODO: Revise to be a many-to-many relationship
    public required List<Race> CareerRaces { get; set; }
    public required int TurfAptitude { get; set; }
    public required int DirtAptitude { get; set; }
    public required int SprintAptitude { get; set; }
    public required int MileAptitude { get; set; }
    public required int MediumAptitude { get; set; }
    public required int LongAptitude { get; set; }
    public required int FrontRunnerAptitude { get; set; }
    public required int PaceChaserAptitude { get; set; }
    public required int LateSurgerAptitude { get; set; }
    public required int EndCloserAptitude { get; set; }
}
