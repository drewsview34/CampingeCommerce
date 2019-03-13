using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Camping.Migrations
{
    public partial class daffd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sku = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "ID", "Description", "Image", "Name", "Price", "Sku" },
                values: new object[,]
                {
                    { 1, "This is a backpack", "/Assets/backpack.jpg", "BackPack", 30m, "BS6000" },
                    { 2, "This is a sleeping bag", "/Assets/sleepingbag.jpg", "Sleeping Gear", 80m, "BS6001" },
                    { 3, "Can be used to help see", "/Assets/flashlight.jpg", "FlashLight", 30m, "BS6002" },
                    { 4, "Can be used to help see", "/Assets/lantern.jpg", "Lantern", 40m, "BS6003" },
                    { 5, "A pair of gloves", "/Assets/gloves.png", "Gloves", 80m, "BS6004" },
                    { 6, "Water shedder", "/Assets/rainshell.jpg", "Rain shell", 20m, "BS6005" },
                    { 7, "luis and clarks map", "/Assets/map.jpg", "Map", 10m, "BS6006" },
                    { 8, "Fire starting kit", "/Assets/flint.jpg", "Flint and Steel", 10m, "BS6007" },
                    { 9, "Baseball cap", "/Assets/hat.jpg", "Hat", 50m, "BS6008" },
                    { 10, "Tracking device", "/Assets/gps.jpg", "Gps", 200m, "BS6009" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventory");
        }
    }
}
