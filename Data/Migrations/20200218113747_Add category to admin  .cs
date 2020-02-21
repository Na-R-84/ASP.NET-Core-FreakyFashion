using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Data.Migrations
{
    public partial class Addcategorytoadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ArticleNumber",
                table: "Product",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "UrlSlug",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UrlSlug",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlSlug",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UrlSlug",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "ArticleNumber",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
