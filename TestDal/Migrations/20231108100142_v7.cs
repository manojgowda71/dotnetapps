using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestDal.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "twomany2s",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_twomany2s", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "twomany3s",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_twomany3s", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "manytomany2",
                columns: table => new
                {
                    manysid = table.Column<int>(type: "int", nullable: false),
                    tomany2sid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manytomany2", x => new { x.manysid, x.tomany2sid });
                    table.ForeignKey(
                        name: "FK_manytomany2_twomany2s_manysid",
                        column: x => x.manysid,
                        principalTable: "twomany2s",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_manytomany2_twomany3s_tomany2sid",
                        column: x => x.tomany2sid,
                        principalTable: "twomany3s",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_manytomany2_tomany2sid",
                table: "manytomany2",
                column: "tomany2sid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "manytomany2");

            migrationBuilder.DropTable(
                name: "twomany2s");

            migrationBuilder.DropTable(
                name: "twomany3s");
        }
    }
}
