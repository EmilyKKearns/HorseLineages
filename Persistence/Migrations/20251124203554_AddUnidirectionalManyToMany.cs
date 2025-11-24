using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddUnidirectionalManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HorseCareerRaces_Horses_HorsesRequiredForHorseId",
                table: "HorseCareerRaces");

            migrationBuilder.DropForeignKey(
                name: "FK_HorseCareerRaces_Races_CareerRacesRaceId",
                table: "HorseCareerRaces");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_HorseSnapshots_HorseSnapshotId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_HorseSnapshotId",
                table: "Races");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HorseCareerRaces",
                table: "HorseCareerRaces");

            migrationBuilder.DropColumn(
                name: "HorseSnapshotId",
                table: "Races");

            migrationBuilder.RenameTable(
                name: "HorseCareerRaces",
                newName: "HorseRace");

            migrationBuilder.RenameColumn(
                name: "HorsesRequiredForHorseId",
                table: "HorseRace",
                newName: "HorseId");

            migrationBuilder.RenameIndex(
                name: "IX_HorseCareerRaces_HorsesRequiredForHorseId",
                table: "HorseRace",
                newName: "IX_HorseRace_HorseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HorseRace",
                table: "HorseRace",
                columns: new[] { "CareerRacesRaceId", "HorseId" });

            migrationBuilder.CreateTable(
                name: "HorseSnapshotRace",
                columns: table => new
                {
                    HorseSnapshotId = table.Column<int>(type: "INTEGER", nullable: false),
                    RacesWonRaceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorseSnapshotRace", x => new { x.HorseSnapshotId, x.RacesWonRaceId });
                    table.ForeignKey(
                        name: "FK_HorseSnapshotRace_HorseSnapshots_HorseSnapshotId",
                        column: x => x.HorseSnapshotId,
                        principalTable: "HorseSnapshots",
                        principalColumn: "HorseSnapshotId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HorseSnapshotRace_Races_RacesWonRaceId",
                        column: x => x.RacesWonRaceId,
                        principalTable: "Races",
                        principalColumn: "RaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HorseSnapshotRace_RacesWonRaceId",
                table: "HorseSnapshotRace",
                column: "RacesWonRaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_HorseRace_Horses_HorseId",
                table: "HorseRace",
                column: "HorseId",
                principalTable: "Horses",
                principalColumn: "HorseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HorseRace_Races_CareerRacesRaceId",
                table: "HorseRace",
                column: "CareerRacesRaceId",
                principalTable: "Races",
                principalColumn: "RaceId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HorseRace_Horses_HorseId",
                table: "HorseRace");

            migrationBuilder.DropForeignKey(
                name: "FK_HorseRace_Races_CareerRacesRaceId",
                table: "HorseRace");

            migrationBuilder.DropTable(
                name: "HorseSnapshotRace");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HorseRace",
                table: "HorseRace");

            migrationBuilder.RenameTable(
                name: "HorseRace",
                newName: "HorseCareerRaces");

            migrationBuilder.RenameColumn(
                name: "HorseId",
                table: "HorseCareerRaces",
                newName: "HorsesRequiredForHorseId");

            migrationBuilder.RenameIndex(
                name: "IX_HorseRace_HorseId",
                table: "HorseCareerRaces",
                newName: "IX_HorseCareerRaces_HorsesRequiredForHorseId");

            migrationBuilder.AddColumn<int>(
                name: "HorseSnapshotId",
                table: "Races",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HorseCareerRaces",
                table: "HorseCareerRaces",
                columns: new[] { "CareerRacesRaceId", "HorsesRequiredForHorseId" });

            migrationBuilder.CreateIndex(
                name: "IX_Races_HorseSnapshotId",
                table: "Races",
                column: "HorseSnapshotId");

            migrationBuilder.AddForeignKey(
                name: "FK_HorseCareerRaces_Horses_HorsesRequiredForHorseId",
                table: "HorseCareerRaces",
                column: "HorsesRequiredForHorseId",
                principalTable: "Horses",
                principalColumn: "HorseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HorseCareerRaces_Races_CareerRacesRaceId",
                table: "HorseCareerRaces",
                column: "CareerRacesRaceId",
                principalTable: "Races",
                principalColumn: "RaceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_HorseSnapshots_HorseSnapshotId",
                table: "Races",
                column: "HorseSnapshotId",
                principalTable: "HorseSnapshots",
                principalColumn: "HorseSnapshotId");
        }
    }
}
