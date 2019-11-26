using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectApp.Migrations
{
    public partial class fulldesc_video1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FullDescriptions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_goods = table.Column<int>(nullable: false),
                    Maker = table.Column<string>(nullable: true),
                    Pruznachennia = table.Column<string>(nullable: true),
                    Obsyag_Videopamyati = table.Column<double>(nullable: false),
                    Tip_Videopamyati = table.Column<string>(nullable: true),
                    Graph_chipset = table.Column<string>(nullable: true),
                    Rozrydnisct = table.Column<double>(nullable: false),
                    Chastota_proc = table.Column<double>(nullable: false),
                    Chastota_video = table.Column<double>(nullable: false),
                    Tip_pidkluchenna = table.Column<string>(nullable: true),
                    display_port = table.Column<bool>(nullable: false),
                    dvi = table.Column<bool>(nullable: false),
                    hdmi = table.Column<bool>(nullable: false),
                    vga = table.Column<bool>(nullable: false),
                    length = table.Column<double>(nullable: false),
                    Stan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullDescriptions", x => x.id);
                    table.ForeignKey(
                        name: "FK_FullDescriptions_Goods_id_goods",
                        column: x => x.id_goods,
                        principalTable: "Goods",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FullDescriptions_id_goods",
                table: "FullDescriptions",
                column: "id_goods",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FullDescriptions");
        }
    }
}
