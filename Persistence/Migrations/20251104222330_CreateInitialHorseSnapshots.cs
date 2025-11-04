using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitialHorseSnapshots : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HorseSnapshots",
                columns: table => new
                {
                    HorseSnapshotId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HorseId = table.Column<int>(type: "INTEGER", nullable: false),
                    Parent1HorseId = table.Column<int>(type: "INTEGER", nullable: false),
                    Parent2HorseId = table.Column<int>(type: "INTEGER", nullable: false),
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
                    GuestOwnerName = table.Column<string>(type: "TEXT", nullable: true),
                    GuestParent1HorseId = table.Column<int>(type: "INTEGER", nullable: false),
                    GuestParent2HorseId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorseSnapshots", x => x.HorseSnapshotId);
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
