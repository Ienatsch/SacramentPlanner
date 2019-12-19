using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentPlanner.Migrations
{
    public partial class SpeakerSacrament : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.AddColumn<string>(
                name: "SpeakerSacrament",
                table: "Planner",
                maxLength: 60,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpeakerSacrament",
                table: "Planner");

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    SpeakerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSpeaker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlannerID = table.Column<int>(type: "int", nullable: true),
                    SacramentID = table.Column<int>(type: "int", nullable: false),
                    SpeakerSubject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.SpeakerID);
                    table.ForeignKey(
                        name: "FK_Speaker_Planner_PlannerID",
                        column: x => x.PlannerID,
                        principalTable: "Planner",
                        principalColumn: "PlannerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_PlannerID",
                table: "Speaker",
                column: "PlannerID");
        }
    }
}
