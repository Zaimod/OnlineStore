using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectApp.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_allDescripts_longDesc_id_longDesc",
                table: "allDescripts");

            migrationBuilder.DropForeignKey(
                name: "FK_allDescripts_shortDesc_id_shortDesc",
                table: "allDescripts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shortDesc",
                table: "shortDesc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_longDesc",
                table: "longDesc");

            migrationBuilder.RenameTable(
                name: "shortDesc",
                newName: "shortDescs");

            migrationBuilder.RenameTable(
                name: "longDesc",
                newName: "LongDescs");

            migrationBuilder.AddColumn<int>(
                name: "id_category",
                table: "Goods",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_discount",
                table: "Goods",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_img",
                table: "Goods",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_shortDescs",
                table: "shortDescs",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LongDescs",
                table: "LongDescs",
                column: "id");

            migrationBuilder.CreateTable(
                name: "categoryPhotos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryPhotos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_goods = table.Column<int>(nullable: false),
                    expires_disck = table.Column<DateTime>(nullable: false),
                    value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsPhotos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    img = table.Column<string>(nullable: true),
                    id_goods = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsPhotos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    id_photo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                    table.ForeignKey(
                        name: "FK_Categories_categoryPhotos_id_photo",
                        column: x => x.id_photo,
                        principalTable: "categoryPhotos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Goods_id_category",
                table: "Goods",
                column: "id_category");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_id_discount",
                table: "Goods",
                column: "id_discount");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_id_img",
                table: "Goods",
                column: "id_img");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_id_photo",
                table: "Categories",
                column: "id_photo");

            migrationBuilder.AddForeignKey(
                name: "FK_allDescripts_LongDescs_id_longDesc",
                table: "allDescripts",
                column: "id_longDesc",
                principalTable: "LongDescs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_allDescripts_shortDescs_id_shortDesc",
                table: "allDescripts",
                column: "id_shortDesc",
                principalTable: "shortDescs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_Categories_id_category",
                table: "Goods",
                column: "id_category",
                principalTable: "Categories",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_allDescripts_LongDescs_id_longDesc",
                table: "allDescripts");

            migrationBuilder.DropForeignKey(
                name: "FK_allDescripts_shortDescs_id_shortDesc",
                table: "allDescripts");

            migrationBuilder.DropForeignKey(
                name: "FK_Goods_Categories_id_category",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Goods_Discounts_id_discount",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Goods_GoodsPhotos_id_img",
                table: "Goods");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "GoodsPhotos");

            migrationBuilder.DropTable(
                name: "categoryPhotos");

            migrationBuilder.DropIndex(
                name: "IX_Goods_id_category",
                table: "Goods");

            migrationBuilder.DropIndex(
                name: "IX_Goods_id_discount",
                table: "Goods");

            migrationBuilder.DropIndex(
                name: "IX_Goods_id_img",
                table: "Goods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shortDescs",
                table: "shortDescs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LongDescs",
                table: "LongDescs");

            migrationBuilder.DropColumn(
                name: "id_category",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "id_discount",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "id_img",
                table: "Goods");

            migrationBuilder.RenameTable(
                name: "shortDescs",
                newName: "shortDesc");

            migrationBuilder.RenameTable(
                name: "LongDescs",
                newName: "longDesc");

            migrationBuilder.AddPrimaryKey(
                name: "PK_shortDesc",
                table: "shortDesc",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_longDesc",
                table: "longDesc",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_allDescripts_longDesc_id_longDesc",
                table: "allDescripts",
                column: "id_longDesc",
                principalTable: "longDesc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_allDescripts_shortDesc_id_shortDesc",
                table: "allDescripts",
                column: "id_shortDesc",
                principalTable: "shortDesc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
