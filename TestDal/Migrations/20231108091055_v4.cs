using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestDal.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "hobbies",
                table: "parents",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hobbies",
                table: "parents");
        }
    }
}
