using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaluationSystem.Migrations
{
    public partial class UpdateTableAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "stronglyDisagree",
                table: "Answers",
                newName: "answerTwo");

            migrationBuilder.RenameColumn(
                name: "stronglyAgree",
                table: "Answers",
                newName: "answerThree");

            migrationBuilder.RenameColumn(
                name: "neutral",
                table: "Answers",
                newName: "answerOne");

            migrationBuilder.RenameColumn(
                name: "disagree",
                table: "Answers",
                newName: "answerFour");

            migrationBuilder.RenameColumn(
                name: "agree",
                table: "Answers",
                newName: "answerFive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "answerTwo",
                table: "Answers",
                newName: "stronglyDisagree");

            migrationBuilder.RenameColumn(
                name: "answerThree",
                table: "Answers",
                newName: "stronglyAgree");

            migrationBuilder.RenameColumn(
                name: "answerOne",
                table: "Answers",
                newName: "neutral");

            migrationBuilder.RenameColumn(
                name: "answerFour",
                table: "Answers",
                newName: "disagree");

            migrationBuilder.RenameColumn(
                name: "answerFive",
                table: "Answers",
                newName: "agree");
        }
    }
}
