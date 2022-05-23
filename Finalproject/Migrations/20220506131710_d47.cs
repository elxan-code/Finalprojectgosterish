using Microsoft.EntityFrameworkCore.Migrations;

namespace Finalproject.Migrations
{
    public partial class d47 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubFeatureId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SubFeature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feature = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubFeature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubFeature_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubFeatureId",
                table: "Products",
                column: "SubFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_SubFeature_CategoryId",
                table: "SubFeature",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubFeature_SubFeatureId",
                table: "Products",
                column: "SubFeatureId",
                principalTable: "SubFeature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubFeature_SubFeatureId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "SubFeature");

            migrationBuilder.DropIndex(
                name: "IX_Products_SubFeatureId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SubFeatureId",
                table: "Products");
        }
    }
}
