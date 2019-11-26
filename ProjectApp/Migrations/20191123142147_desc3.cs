using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectApp.Migrations
{
    public partial class desc3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Descriptions_id_goods",
                table: "Descriptions");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_id_goods",
                table: "Descriptions",
                column: "id_goods",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Descriptions_id_goods",
                table: "Descriptions");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_id_goods",
                table: "Descriptions",
                column: "id_goods");
        }
    }
}
