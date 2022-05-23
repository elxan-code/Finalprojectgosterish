using Microsoft.EntityFrameworkCore.Migrations;

namespace Finalproject.Migrations
{
    public partial class fatureeee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductOfProducts_ProductOfProductId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductOfProductId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ProductOfProductId",
                table: "ProductImages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductOfProductId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductOfProductId",
                table: "ProductImages",
                column: "ProductOfProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductOfProducts_ProductOfProductId",
                table: "ProductImages",
                column: "ProductOfProductId",
                principalTable: "ProductOfProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
