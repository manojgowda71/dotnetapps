using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HolidayDal.Migrations
{
    public partial class a5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Holiemployee_designation_roledesignationId",
                table: "Holiemployee");

            migrationBuilder.DropIndex(
                name: "IX_Holiemployee_roledesignationId",
                table: "Holiemployee");

            migrationBuilder.DropColumn(
                name: "roledesignationId",
                table: "Holiemployee");

            migrationBuilder.AddColumn<int>(
                name: "roleempId",
                table: "designation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_designation_roleempId",
                table: "designation",
                column: "roleempId");

            migrationBuilder.AddForeignKey(
                name: "FK_designation_Holiemployee_roleempId",
                table: "designation",
                column: "roleempId",
                principalTable: "Holiemployee",
                principalColumn: "empId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_designation_Holiemployee_roleempId",
                table: "designation");

            migrationBuilder.DropIndex(
                name: "IX_designation_roleempId",
                table: "designation");

            migrationBuilder.DropColumn(
                name: "roleempId",
                table: "designation");

            migrationBuilder.AddColumn<int>(
                name: "roledesignationId",
                table: "Holiemployee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Holiemployee_roledesignationId",
                table: "Holiemployee",
                column: "roledesignationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Holiemployee_designation_roledesignationId",
                table: "Holiemployee",
                column: "roledesignationId",
                principalTable: "designation",
                principalColumn: "designationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
