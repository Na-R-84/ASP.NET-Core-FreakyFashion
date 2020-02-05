using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Data.Migrations
{
    public partial class removeCategoryProductindiviualId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "CategoryProducts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CategoryProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
