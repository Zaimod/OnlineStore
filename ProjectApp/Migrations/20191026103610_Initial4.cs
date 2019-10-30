using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectApp.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "avatar_id",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "longDesc",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_longDesc", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "shortDesc",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shortDesc", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "allDescripts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_longDesc = table.Column<int>(nullable: false),
                    id_shortDesc = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_allDescripts", x => x.id);
                    table.ForeignKey(
                        name: "FK_allDescripts_longDesc_id_longDesc",
                        column: x => x.id_longDesc,
                        principalTable: "longDesc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_allDescripts_shortDesc_id_shortDesc",
                        column: x => x.id_shortDesc,
                        principalTable: "shortDesc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: false),
                    price = table.Column<double>(nullable: false),
                    isFavourite = table.Column<bool>(nullable: false),
                    isAvailable = table.Column<bool>(nullable: false),
                    id_allDesc = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.id);
                    table.ForeignKey(
                        name: "FK_Goods_allDescripts_id_allDesc",
                        column: x => x.id_allDesc,
                        principalTable: "allDescripts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    comment = table.Column<string>(nullable: false),
                    datetime = table.Column<DateTime>(nullable: false),
                    id_user = table.Column<int>(nullable: false),
                    id_goods = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comments_Goods_id_goods",
                        column: x => x.id_goods,
                        principalTable: "Goods",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_id_user",
                        column: x => x.id_user,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "selectedProds",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_user = table.Column<int>(nullable: false),
                    id_goods = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_selectedProds", x => x.id);
                    table.ForeignKey(
                        name: "FK_selectedProds_Goods_id_goods",
                        column: x => x.id_goods,
                        principalTable: "Goods",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_selectedProds_Users_id_user",
                        column: x => x.id_user,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_allDescripts_id_longDesc",
                table: "allDescripts",
                column: "id_longDesc");

            migrationBuilder.CreateIndex(
                name: "IX_allDescripts_id_shortDesc",
                table: "allDescripts",
                column: "id_shortDesc");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_id_goods",
                table: "Comments",
                column: "id_goods");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_id_user",
                table: "Comments",
                column: "id_user");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_id_allDesc",
                table: "Goods",
                column: "id_allDesc");

            migrationBuilder.CreateIndex(
                name: "IX_selectedProds_id_goods",
                table: "selectedProds",
                column: "id_goods");

            migrationBuilder.CreateIndex(
                name: "IX_selectedProds_id_user",
                table: "selectedProds",
                column: "id_user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "selectedProds");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "allDescripts");

            migrationBuilder.DropTable(
                name: "longDesc");

            migrationBuilder.DropTable(
                name: "shortDesc");

            migrationBuilder.DropColumn(
                name: "avatar_id",
                table: "Users");
        }
    }
}
