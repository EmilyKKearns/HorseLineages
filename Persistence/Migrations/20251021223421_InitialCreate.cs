using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HorseSnapshots",
                columns: table => new
                {
                    HorseSnapshotId = table.Column<int>(type: "INTEGER", nullable: true),
                    HorseId = table.Column<int>(type: "INTEGER", nullable: false),
                    Parent1HorseId = table.Column<int>(type: "INTEGER", nullable: true),
                    Parent2HorseId = table.Column<int>(type: "INTEGER", nullable: true),
                    Rank = table.Column<string>(type: "TEXT", nullable: false),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    StarLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    PotentialLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    UniqueSkillLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    Speed = table.Column<int>(type: "INTEGER", nullable: false),
                    Stamina = table.Column<int>(type: "INTEGER", nullable: false),
                    Power = table.Column<int>(type: "INTEGER", nullable: false),
                    Guts = table.Column<int>(type: "INTEGER", nullable: false),
                    Wit = table.Column<int>(type: "INTEGER", nullable: false),
                    IsGuest = table.Column<bool>(type: "INTEGER", nullable: false),
                    GuestOwnerName = table.Column<string>(type: "TEXT", nullable: false),
                    GuestParent1HorseId = table.Column<int>(type: "INTEGER", nullable: true),
                    GuestParent2HorseId = table.Column<int>(type: "INTEGER", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.HorseSnapshotId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HorseSnapshots");
        }
    }
}
