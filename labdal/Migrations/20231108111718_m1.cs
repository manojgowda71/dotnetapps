using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace labdal.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "course",
                columns: table => new
                {
                    courseid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course", x => x.courseid);
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stuName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "coursestudent",
                columns: table => new
                {
                    applycourseId = table.Column<int>(type: "int", nullable: false),
                    courseid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coursestudent", x => new { x.applycourseId, x.courseid });
                    table.ForeignKey(
                        name: "FK_coursestudent_course_courseid",
                        column: x => x.courseid,
                        principalTable: "course",
                        principalColumn: "courseid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_coursestudent_student_applycourseId",
                        column: x => x.applycourseId,
                        principalTable: "student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_coursestudent_courseid",
                table: "coursestudent",
                column: "courseid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coursestudent");

            migrationBuilder.DropTable(
                name: "course");

            migrationBuilder.DropTable(
                name: "student");
        }
    }
}
