using Microsoft.EntityFrameworkCore.Migrations;

namespace Finalproject.Migrations
{
    public partial class feature1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductOfProduct_ProductOfProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOfProduct_Products_ProductId",
                table: "ProductOfProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductOfProduct",
                table: "ProductOfProduct");

            migrationBuilder.RenameTable(
                name: "ProductOfProduct",
                newName: "ProductOfProducts");

            migrationBuilder.RenameIndex(
                name: "IX_ProductOfProduct_ProductId",
                table: "ProductOfProducts",
                newName: "IX_ProductOfProducts_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductOfProducts",
                table: "ProductOfProducts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ProductFatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureMain = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FeatureChild = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductOfProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFatures_ProductOfProducts_ProductOfProductId",
                        column: x => x.ProductOfProductId,
                        principalTable: "ProductOfProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFatures_ProductOfProductId",
                table: "ProductFatures",
                column: "ProductOfProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductOfProducts_ProductOfProductId",
                table: "ProductImages",
                column: "ProductOfProductId",
                principalTable: "ProductOfProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOfProducts_Products_ProductId",
                table: "ProductOfProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductOfProducts_ProductOfProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOfProducts_Products_ProductId",
                table: "ProductOfProducts");

            migrationBuilder.DropTable(
                name: "ProductFatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductOfProducts",
                table: "ProductOfProducts");

            migrationBuilder.RenameTable(
                name: "ProductOfProducts",
                newName: "ProductOfProduct");

            migrationBuilder.RenameIndex(
                name: "IX_ProductOfProducts_ProductId",
                table: "ProductOfProduct",
                newName: "IX_ProductOfProduct_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductOfProduct",
                table: "ProductOfProduct",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductOfProduct_ProductOfProductId",
                table: "ProductImages",
                column: "ProductOfProductId",
                principalTable: "ProductOfProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOfProduct_Products_ProductId",
                table: "ProductOfProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
