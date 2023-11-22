using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestDal.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "twomanyid",
                table: "one",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "twomanys",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_twomanys", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_one_twomanyid",
                table: "one",
                column: "twomanyid");

            migrationBuilder.AddForeignKey(
                name: "FK_one_twomanys_twomanyid",
                table: "one",
                column: "twomanyid",
                principalTable: "twomanys",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_one_twomanys_twomanyid",
                table: "one");

            migrationBuilder.DropTable(
                name: "twomanys");

            migrationBuilder.DropIndex(
                name: "IX_one_twomanyid",
                table: "one");

            migrationBuilder.DropColumn(
                name: "twomanyid",
                table: "one");
        }
    }
}
