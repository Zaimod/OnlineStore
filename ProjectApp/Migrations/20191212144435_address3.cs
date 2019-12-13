using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectApp.Migrations
{
    public partial class address3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressUser_Users_user_id",
                table: "AddressUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressUser",
                table: "AddressUser");

            migrationBuilder.RenameTable(
                name: "AddressUser",
                newName: "addressUsers");

            migrationBuilder.RenameIndex(
                name: "IX_AddressUser_user_id",
                table: "addressUsers",
                newName: "IX_addressUsers_user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_addressUsers",
                table: "addressUsers",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_addressUsers_Users_user_id",
                table: "addressUsers",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_addressUsers_Users_user_id",
                table: "addressUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_addressUsers",
                table: "addressUsers");

            migrationBuilder.RenameTable(
                name: "addressUsers",
                newName: "AddressUser");

            migrationBuilder.RenameIndex(
                name: "IX_addressUsers_user_id",
                table: "AddressUser",
                newName: "IX_AddressUser_user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressUser",
                table: "AddressUser",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressUser_Users_user_id",
                table: "AddressUser",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
