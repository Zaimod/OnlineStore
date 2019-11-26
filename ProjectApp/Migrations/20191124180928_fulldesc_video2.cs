using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectApp.Migrations
{
    public partial class fulldesc_video2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FullDescriptions_Goods_id_goods",
                table: "FullDescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FullDescriptions",
                table: "FullDescriptions");

            migrationBuilder.RenameTable(
                name: "FullDescriptions",
                newName: "FullDescription_Video");

            migrationBuilder.RenameIndex(
                name: "IX_FullDescriptions_id_goods",
                table: "FullDescription_Video",
                newName: "IX_FullDescription_Video_id_goods");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FullDescription_Video",
                table: "FullDescription_Video",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_FullDescription_Video_Goods_id_goods",
                table: "FullDescription_Video",
                column: "id_goods",
                principalTable: "Goods",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FullDescription_Video_Goods_id_goods",
                table: "FullDescription_Video");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FullDescription_Video",
                table: "FullDescription_Video");

            migrationBuilder.RenameTable(
                name: "FullDescription_Video",
                newName: "FullDescriptions");

            migrationBuilder.RenameIndex(
                name: "IX_FullDescription_Video_id_goods",
                table: "FullDescriptions",
                newName: "IX_FullDescriptions_id_goods");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FullDescriptions",
                table: "FullDescriptions",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_FullDescriptions_Goods_id_goods",
                table: "FullDescriptions",
                column: "id_goods",
                principalTable: "Goods",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
