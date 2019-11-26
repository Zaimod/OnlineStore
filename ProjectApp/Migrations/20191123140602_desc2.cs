using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectApp.Migrations
{
    public partial class desc2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Description_Goods_id_goods",
                table: "Description");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Description",
                table: "Description");

            migrationBuilder.RenameTable(
                name: "Description",
                newName: "Descriptions");

            migrationBuilder.RenameIndex(
                name: "IX_Description_id_goods",
                table: "Descriptions",
                newName: "IX_Descriptions_id_goods");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Descriptions",
                table: "Descriptions",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Descriptions_Goods_id_goods",
                table: "Descriptions",
                column: "id_goods",
                principalTable: "Goods",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Descriptions_Goods_id_goods",
                table: "Descriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Descriptions",
                table: "Descriptions");

            migrationBuilder.RenameTable(
                name: "Descriptions",
                newName: "Description");

            migrationBuilder.RenameIndex(
                name: "IX_Descriptions_id_goods",
                table: "Description",
                newName: "IX_Description_id_goods");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Description",
                table: "Description",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Description_Goods_id_goods",
                table: "Description",
                column: "id_goods",
                principalTable: "Goods",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
