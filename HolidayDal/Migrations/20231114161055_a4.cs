using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HolidayDal.Migrations
{
    public partial class a4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.AddColumn<int>(
                name: "experience",
                table: "designation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Holiemployee",
                columns: table => new
                {
                    empId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    isactive = table.Column<bool>(type: "bit", nullable: false),
                    DOJ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    roledesignationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holiemployee", x => x.empId);
                    table.ForeignKey(
                        name: "FK_Holiemployee_designation_roledesignationId",
                        column: x => x.roledesignationId,
                        principalTable: "designation",
                        principalColumn: "designationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Holiemployee_roledesignationId",
                table: "Holiemployee",
                column: "roledesignationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Holiemployee");

            migrationBuilder.DropColumn(
                name: "experience",
                table: "designation");

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    empId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roledesignationId = table.Column<int>(type: "int", nullable: false),
                    DOJ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    empName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    isactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.empId);
                    table.ForeignKey(
                        name: "FK_employee_designation_roledesignationId",
                        column: x => x.roledesignationId,
                        principalTable: "designation",
                        principalColumn: "designationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employee_roledesignationId",
                table: "employee",
                column: "roledesignationId");
        }
    }
}
