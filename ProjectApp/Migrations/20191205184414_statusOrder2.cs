using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectApp.Migrations
{
    public partial class statusOrder2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_orderDetailRegisters_GoodsID",
                table: "orderDetailRegisters");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetailRegisters_GoodsID",
                table: "orderDetailRegisters",
                column: "GoodsID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_orderDetailRegisters_GoodsID",
                table: "orderDetailRegisters");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetailRegisters_GoodsID",
                table: "orderDetailRegisters",
                column: "GoodsID");
        }
    }
}
