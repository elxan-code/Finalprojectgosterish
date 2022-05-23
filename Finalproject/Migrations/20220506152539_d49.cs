using Microsoft.EntityFrameworkCore.Migrations;

namespace Finalproject.Migrations
{
    public partial class d49 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubFeatures_SubFeatureId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SubFeatureId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SubFeatureId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "FeatureTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubFeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeatureTitles_SubFeatures_SubFeatureId",
                        column: x => x.SubFeatureId,
                        principalTable: "SubFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeatureTitles_SubFeatureId",
                table: "FeatureTitles",
                column: "SubFeatureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeatureTitles");

            migrationBuilder.AddColumn<int>(
                name: "SubFeatureId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubFeatureId",
                table: "Products",
                column: "SubFeatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubFeatures_SubFeatureId",
                table: "Products",
                column: "SubFeatureId",
                principalTable: "SubFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
