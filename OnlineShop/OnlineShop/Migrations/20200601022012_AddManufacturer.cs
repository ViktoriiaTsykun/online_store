using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Migrations
{
    public partial class AddManufacturer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "manufacturerID",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    manufacturerName = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_manufacturerID",
                table: "Products",
                column: "manufacturerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Manufacturers_manufacturerID",
                table: "Products",
                column: "manufacturerID",
                principalTable: "Manufacturers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Manufacturers_manufacturerID",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropIndex(
                name: "IX_Products_manufacturerID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "manufacturerID",
                table: "Products");
        }
    }
}
