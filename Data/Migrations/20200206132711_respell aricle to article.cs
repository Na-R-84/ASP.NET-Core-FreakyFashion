using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Data.Migrations
{
    public partial class respellaricletoarticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AricleNumber",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ArticleNumber",
                table: "Product",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleNumber",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "AricleNumber",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
