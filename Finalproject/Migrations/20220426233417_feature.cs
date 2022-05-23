using Microsoft.EntityFrameworkCore.Migrations;

namespace Finalproject.Migrations
{
    public partial class feature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductOfProductId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductOfProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOfProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductOfProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductOfProductId",
                table: "ProductImages",
                column: "ProductOfProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOfProduct_ProductId",
                table: "ProductOfProduct",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductOfProduct_ProductOfProductId",
                table: "ProductImages",
                column: "ProductOfProductId",
                principalTable: "ProductOfProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductOfProduct_ProductOfProductId",
                table: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductOfProduct");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductOfProductId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ProductOfProductId",
                table: "ProductImages");
        }
    }
}
