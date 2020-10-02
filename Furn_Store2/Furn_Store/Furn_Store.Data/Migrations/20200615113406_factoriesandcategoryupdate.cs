using Microsoft.EntityFrameworkCore.Migrations;

namespace Furn_Store.Data.Migrations
{
    public partial class factoriesandcategoryupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Factory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Category",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Category");
        }
    }
}
