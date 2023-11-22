using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestDal.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "one",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_one", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "toones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    relatedtooneid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toones", x => x.id);
                    table.ForeignKey(
                        name: "FK_toones_one_relatedtooneid",
                        column: x => x.relatedtooneid,
                        principalTable: "one",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_toones_relatedtooneid",
                table: "toones",
                column: "relatedtooneid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "toones");

            migrationBuilder.DropTable(
                name: "one");
        }
    }
}
