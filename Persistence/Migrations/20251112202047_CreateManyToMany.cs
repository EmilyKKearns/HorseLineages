using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DirtAptitude",
                table: "HorseSnapshots",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EndCloserAptitude",
                table: "HorseSnapshots",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FrontRunnerAptitude",
                table: "HorseSnapshots",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LateSurgerAptitude",
                table: "HorseSnapshots",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LongAptitude",
                table: "HorseSnapshots",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MediumAptitude",
                table: "HorseSnapshots",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MileAptitude",
                table: "HorseSnapshots",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaceChaserAptitude",
                table: "HorseSnapshots",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SprintAptitude",
                table: "HorseSnapshots",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TurfAptitude",
                table: "HorseSnapshots",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Horses",
                columns: table => new
                {
                    HorseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    TurfAptitude = table.Column<string>(type: "TEXT", nullable: false),
                    DirtAptitude = table.Column<string>(type: "TEXT", nullable: false),
                    SprintAptitude = table.Column<string>(type: "TEXT", nullable: false),
                    MileAptitude = table.Column<string>(type: "TEXT", nullable: false),
                    MediumAptitude = table.Column<string>(type: "TEXT", nullable: false),
                    LongAptitude = table.Column<string>(type: "TEXT", nullable: false),
                    FrontRunnerAptitude = table.Column<string>(type: "TEXT", nullable: false),
                    PaceChaserAptitude = table.Column<string>(type: "TEXT", nullable: false),
                    LateSurgerAptitude = table.Column<string>(type: "TEXT", nullable: false),
                    EndCloserAptitude = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horses", x => x.HorseId);
                });

            migrationBuilder.CreateTable(
                name: "HorseCareerRaces",
                columns: table => new
                {
                    CareerRacesRaceId = table.Column<int>(type: "INTEGER", nullable: false),
                    HorsesRequiredForHorseId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorseCareerRaces", x => new { x.CareerRacesRaceId, x.HorsesRequiredForHorseId });
                    table.ForeignKey(
                        name: "FK_HorseCareerRaces_Horses_HorsesRequiredForHorseId",
                        column: x => x.HorsesRequiredForHorseId,
                        principalTable: "Horses",
                        principalColumn: "HorseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HorseCareerRaces_Races_CareerRacesRaceId",
                        column: x => x.CareerRacesRaceId,
                        principalTable: "Races",
                        principalColumn: "RaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HorseCareerRaces_HorsesRequiredForHorseId",
                table: "HorseCareerRaces",
                column: "HorsesRequiredForHorseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HorseCareerRaces");

            migrationBuilder.DropTable(
                name: "Horses");

            migrationBuilder.DropColumn(
                name: "DirtAptitude",
                table: "HorseSnapshots");

            migrationBuilder.DropColumn(
                name: "EndCloserAptitude",
                table: "HorseSnapshots");

            migrationBuilder.DropColumn(
                name: "FrontRunnerAptitude",
                table: "HorseSnapshots");

            migrationBuilder.DropColumn(
                name: "LateSurgerAptitude",
                table: "HorseSnapshots");

            migrationBuilder.DropColumn(
                name: "LongAptitude",
                table: "HorseSnapshots");

            migrationBuilder.DropColumn(
                name: "MediumAptitude",
                table: "HorseSnapshots");

            migrationBuilder.DropColumn(
                name: "MileAptitude",
                table: "HorseSnapshots");

            migrationBuilder.DropColumn(
                name: "PaceChaserAptitude",
                table: "HorseSnapshots");

            migrationBuilder.DropColumn(
                name: "SprintAptitude",
                table: "HorseSnapshots");

            migrationBuilder.DropColumn(
                name: "TurfAptitude",
                table: "HorseSnapshots");
        }
    }
}
