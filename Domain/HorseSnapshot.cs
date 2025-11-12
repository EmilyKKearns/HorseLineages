using System;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class HorseSnapshot
{
    [Key]
    public int HorseSnapshotId { get; set; }
    public required int HorseId { get; set; }
    public int Parent1HorseId { get; set; }
    public int Parent2HorseId { get; set; }
    public required List<Race> RacesWon { get; set; }
    public required string Rank { get; set; }
    public required int Score { get; set; }
    public required int StarLevel { get; set; }
    public required int PotentialLevel { get; set; }
    public required int UniqueSkillLevel { get; set; }
    public required int Speed { get; set; }
    public required int Stamina { get; set; }
    public required int Power { get; set; }
    public required int Guts { get; set; }
    public required int Wit { get; set; }
    public required bool IsGuest { get; set; }
    public string? GuestOwnerName { get; set; }
    public int GuestParent1HorseId { get; set; }
    public int GuestParent2HorseId { get; set; }
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
