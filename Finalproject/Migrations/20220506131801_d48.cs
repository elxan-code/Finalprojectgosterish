using Microsoft.EntityFrameworkCore.Migrations;

namespace Finalproject.Migrations
{
    public partial class d48 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubFeature_SubFeatureId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SubFeature_Categories_CategoryId",
                table: "SubFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubFeature",
                table: "SubFeature");

            migrationBuilder.RenameTable(
                name: "SubFeature",
                newName: "SubFeatures");

            migrationBuilder.RenameIndex(
                name: "IX_SubFeature_CategoryId",
                table: "SubFeatures",
                newName: "IX_SubFeatures_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubFeatures",
                table: "SubFeatures",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubFeatures_SubFeatureId",
                table: "Products",
                column: "SubFeatureId",
                principalTable: "SubFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubFeatures_Categories_CategoryId",
                table: "SubFeatures",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubFeatures_SubFeatureId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SubFeatures_Categories_CategoryId",
                table: "SubFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubFeatures",
                table: "SubFeatures");

            migrationBuilder.RenameTable(
                name: "SubFeatures",
                newName: "SubFeature");

            migrationBuilder.RenameIndex(
                name: "IX_SubFeatures_CategoryId",
                table: "SubFeature",
                newName: "IX_SubFeature_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubFeature",
                table: "SubFeature",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubFeature_SubFeatureId",
                table: "Products",
                column: "SubFeatureId",
                principalTable: "SubFeature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubFeature_Categories_CategoryId",
                table: "SubFeature",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
