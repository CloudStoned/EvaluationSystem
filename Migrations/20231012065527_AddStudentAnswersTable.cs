using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaluationSystem.Migrations
{
    public partial class AddStudentAnswersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentAnswers",
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
                    table.PrimaryKey("PK_StudentAnswers", x => x.answerId);
                    table.ForeignKey(
                        name: "FK_StudentAnswers_Professors_professorId",
                        column: x => x.professorId,
                        principalTable: "Professors",
                        principalColumn: "professorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAnswers_Students_studentNumber",
                        column: x => x.studentNumber,
                        principalTable: "Students",
                        principalColumn: "studentNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswers_professorId",
                table: "StudentAnswers",
                column: "professorId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswers_studentNumber",
                table: "StudentAnswers",
                column: "studentNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentAnswers");
        }
    }
}
