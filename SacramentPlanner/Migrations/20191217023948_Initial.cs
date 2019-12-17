using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentPlanner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planner",
                columns: table => new
                {
                    PlannerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WardBranch = table.Column<string>(maxLength: 60, nullable: true),
                    SabbathDay = table.Column<DateTime>(nullable: false),
                    ConductingLeader = table.Column<string>(maxLength: 60, nullable: true),
                    OpenHymn = table.Column<string>(maxLength: 30, nullable: false),
                    OpenPrayer = table.Column<string>(maxLength: 60, nullable: true),
                    SacramentHymn = table.Column<string>(maxLength: 30, nullable: false),
                    ClosingHymn = table.Column<string>(maxLength: 30, nullable: false),
                    ClosingPrayer = table.Column<string>(maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planner", x => x.PlannerID);
                });

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    SpeakerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SacramentID = table.Column<int>(nullable: false),
                    NameSpeaker = table.Column<string>(nullable: true),
                    SpeakerSubject = table.Column<string>(nullable: true),
                    PlannerID = table.Column<int>(nullable: true)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.DropTable(
                name: "Planner");
        }
    }
}
