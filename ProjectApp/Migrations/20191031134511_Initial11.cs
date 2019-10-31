using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectApp.Migrations
{
    public partial class Initial11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goods_allDescripts_id_allDesc",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Goods_Discounts_id_discount",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Goods_GoodsPhotos_id_img",
                table: "Goods");

            migrationBuilder.DropIndex(
                name: "IX_Goods_id_allDesc",
                table: "Goods");

            migrationBuilder.DropIndex(
                name: "IX_Goods_id_discount",
                table: "Goods");

            migrationBuilder.DropIndex(
                name: "IX_Goods_id_img",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "id_allDesc",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "id_discount",
                table: "Goods");

            migrationBuilder.AddColumn<int>(
                name: "id_goods",
                table: "allDescripts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GoodsPhotos_id_goods",
                table: "GoodsPhotos",
                column: "id_goods");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_id_goods",
                table: "Discounts",
                column: "id_goods");

            migrationBuilder.CreateIndex(
                name: "IX_allDescripts_id_goods",
                table: "allDescripts",
                column: "id_goods");

            migrationBuilder.AddForeignKey(
                name: "FK_allDescripts_Goods_id_goods",
                table: "allDescripts",
                column: "id_goods",
                principalTable: "Goods",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Discounts_Goods_id_goods",
                table: "Discounts",
                column: "id_goods",
                principalTable: "Goods",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsPhotos_Goods_id_goods",
                table: "GoodsPhotos",
                column: "id_goods",
                principalTable: "Goods",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_allDescripts_Goods_id_goods",
                table: "allDescripts");

            migrationBuilder.DropForeignKey(
                name: "FK_Discounts_Goods_id_goods",
                table: "Discounts");

            migrationBuilder.DropForeignKey(
                name: "FK_GoodsPhotos_Goods_id_goods",
                table: "GoodsPhotos");

            migrationBuilder.DropIndex(
                name: "IX_GoodsPhotos_id_goods",
                table: "GoodsPhotos");

            migrationBuilder.DropIndex(
                name: "IX_Discounts_id_goods",
                table: "Discounts");

            migrationBuilder.DropIndex(
                name: "IX_allDescripts_id_goods",
                table: "allDescripts");

            migrationBuilder.DropColumn(
                name: "id_goods",
                table: "allDescripts");

            migrationBuilder.AddColumn<int>(
                name: "id_allDesc",
                table: "Goods",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_discount",
                table: "Goods",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Goods_id_allDesc",
                table: "Goods",
                column: "id_allDesc");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_id_discount",
                table: "Goods",
                column: "id_discount");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_id_img",
                table: "Goods",
                column: "id_img");

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_allDescripts_id_allDesc",
                table: "Goods",
                column: "id_allDesc",
                principalTable: "allDescripts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_Discounts_id_discount",
                table: "Goods",
                column: "id_discount",
                principalTable: "Discounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_GoodsPhotos_id_img",
                table: "Goods",
                column: "id_img",
                principalTable: "GoodsPhotos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
