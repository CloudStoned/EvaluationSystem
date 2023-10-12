using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaluationSystem.Migrations
{
    public partial class AddAnswersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    answerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentNumber = table.Column<int>(type: "int", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    course = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yearLevel = table.Column<int>(type: "int", nullable: false),
                    answerOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    answerTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    answerThree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    answerFour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    answerFive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    professorId = table.Column<int>(type: "int", nullable: false),
                    dateEvaluated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.answerId);
                    table.ForeignKey(
                        name: "FK_Answers_Professors_professorId",
                        column: x => x.professorId,
                        principalTable: "Professors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answers_Students_studentNumber",
                        column: x => x.studentNumber,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_professorId",
                table: "Answers",
                column: "professorId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_studentNumber",
                table: "Answers",
                column: "studentNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");
        }
    }
}
