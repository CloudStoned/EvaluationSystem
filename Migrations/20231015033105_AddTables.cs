using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaluationSystem.Migrations
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professors",
                columns: table => new
                {
                    professorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    professorFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    professorLastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professors", x => x.professorId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    studentNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentCourse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentYearLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.studentNumber);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    answerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stronglyAgree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    agree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    neutral = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    disagree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stronglyDisagree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentFK = table.Column<int>(type: "int", nullable: false),
                    professorFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.answerId);
                    table.ForeignKey(
                        name: "FK_Answers_Professors_professorFK",
                        column: x => x.professorFK,
                        principalTable: "Professors",
                        principalColumn: "professorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answers_Students_studentFK",
                        column: x => x.studentFK,
                        principalTable: "Students",
                        principalColumn: "studentNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_professorFK",
                table: "Answers",
                column: "professorFK");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_studentFK",
                table: "Answers",
                column: "studentFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Professors");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
