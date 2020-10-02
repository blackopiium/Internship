using Microsoft.EntityFrameworkCore.Migrations;

namespace Furn_Store.Data.Migrations
{
    public partial class charch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Charachteristics_Item_Id",
                table: "Item",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Charachteristics_Item_Id",
                table: "Item");
        }
    }
}
