using System;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Horse
{
    [Key]

    public int HorseId { get; set; }
    public required List<Race> CareerRaces { get; set; }
    public required string Name { get; set; }
    public required string TurfAptitude { get; set; }
    public required string DirtAptitude { get; set; }
    public required string SprintAptitude { get; set; }
    public required string MileAptitude { get; set; }
    public required string MediumAptitude { get; set; }
    public required string LongAptitude { get; set; }
    public required string FrontRunnerAptitude { get; set; }
    public required string PaceChaserAptitude { get; set; }
    public required string LateSurgerAptitude { get; set; }
    public required string EndCloserAptitude { get; set; }
}
