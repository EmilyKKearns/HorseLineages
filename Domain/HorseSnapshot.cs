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
}
