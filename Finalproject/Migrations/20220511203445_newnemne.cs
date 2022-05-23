using Microsoft.EntityFrameworkCore.Migrations;

namespace Finalproject.Migrations
{
    public partial class newnemne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "FeatureTitles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FeatureTitles_ProductId",
                table: "FeatureTitles",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureTitles_Products_ProductId",
                table: "FeatureTitles",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeatureTitles_Products_ProductId",
                table: "FeatureTitles");

            migrationBuilder.DropIndex(
                name: "IX_FeatureTitles_ProductId",
                table: "FeatureTitles");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "FeatureTitles");
        }
    }
}
