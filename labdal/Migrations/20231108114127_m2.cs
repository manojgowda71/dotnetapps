using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace labdal.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_coursestudent_course_courseid",
                table: "coursestudent");

            migrationBuilder.DropForeignKey(
                name: "FK_coursestudent_student_applycourseId",
                table: "coursestudent");

            migrationBuilder.RenameColumn(
                name: "courseid",
                table: "coursestudent",
                newName: "manystudentsId");

            migrationBuilder.RenameColumn(
                name: "applycourseId",
                table: "coursestudent",
                newName: "coursescourseid");

            migrationBuilder.RenameIndex(
                name: "IX_coursestudent_courseid",
                table: "coursestudent",
                newName: "IX_coursestudent_manystudentsId");

            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    companyid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    companyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    joinedcmpnyyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.companyid);
                    table.ForeignKey(
                        name: "FK_companies_student_joinedcmpnyyId",
                        column: x => x.joinedcmpnyyId,
                        principalTable: "student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_companies_joinedcmpnyyId",
                table: "companies",
                column: "joinedcmpnyyId");

            migrationBuilder.AddForeignKey(
                name: "FK_coursestudent_course_coursescourseid",
                table: "coursestudent",
                column: "coursescourseid",
                principalTable: "course",
                principalColumn: "courseid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_coursestudent_student_manystudentsId",
                table: "coursestudent",
                column: "manystudentsId",
                principalTable: "student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_coursestudent_course_coursescourseid",
                table: "coursestudent");

            migrationBuilder.DropForeignKey(
                name: "FK_coursestudent_student_manystudentsId",
                table: "coursestudent");

            migrationBuilder.DropTable(
                name: "companies");

            migrationBuilder.RenameColumn(
                name: "manystudentsId",
                table: "coursestudent",
                newName: "courseid");

            migrationBuilder.RenameColumn(
                name: "coursescourseid",
                table: "coursestudent",
                newName: "applycourseId");

            migrationBuilder.RenameIndex(
                name: "IX_coursestudent_manystudentsId",
                table: "coursestudent",
                newName: "IX_coursestudent_courseid");

            migrationBuilder.AddForeignKey(
                name: "FK_coursestudent_course_courseid",
                table: "coursestudent",
                column: "courseid",
                principalTable: "course",
                principalColumn: "courseid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_coursestudent_student_applycourseId",
                table: "coursestudent",
                column: "applycourseId",
                principalTable: "student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
