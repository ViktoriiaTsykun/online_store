using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Migrations
{
    public partial class AddRouting1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_Categoryid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "categoryName",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Categoryid",
                table: "Products",
                newName: "categoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Categoryid",
                table: "Products",
                newName: "IX_Products_categoryID");

            migrationBuilder.AlterColumn<int>(
                name: "categoryID",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_categoryID",
                table: "Products",
                column: "categoryID",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_categoryID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "categoryID",
                table: "Products",
                newName: "Categoryid");

            migrationBuilder.RenameIndex(
                name: "IX_Products_categoryID",
                table: "Products",
                newName: "IX_Products_Categoryid");

            migrationBuilder.AlterColumn<int>(
                name: "Categoryid",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "categoryName",
                table: "Products",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_Categoryid",
                table: "Products",
                column: "Categoryid",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
