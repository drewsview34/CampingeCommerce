using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Camping.Migrations
{
    public partial class init : Migration
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
                    { 1, "", "", "Tent", 90m, "BS6-002" },
                    { 2, "", "", "Sleeping Gear", 80m, "BS6-003" },
                    { 3, "", "", "FlashLight", 30m, "BS6-004" },
                    { 4, "", "", "lanterns", 40m, "BS6-006" },
                    { 5, "", "", "Gloves", 80m, "BS6-007" },
                    { 6, "", "", "Rain shell", 20m, "BS6-008" },
                    { 7, "", "", "map", 10m, "bs6-009" },
                    { 8, "", "", "lighter", 10m, "BS6-000" },
                    { 9, "", "", "Hat", 50m, "" },
                    { 10, "", "", "Gps", 200m, "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventory");
        }
    }
}
