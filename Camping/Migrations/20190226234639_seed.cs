using Microsoft.EntityFrameworkCore.Migrations;

namespace Camping.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ID",
                keyValue: 5,
                column: "Image",
                value: "/Assets/gloves.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "ID",
                keyValue: 5,
                column: "Image",
                value: "~/Assets/gloves.png");
        }
    }
}
