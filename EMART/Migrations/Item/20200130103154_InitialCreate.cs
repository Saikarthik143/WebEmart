using Microsoft.EntityFrameworkCore.Migrations;

namespace EMART.Migrations.Item
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_id = table.Column<int>(nullable: false),
                    category_name = table.Column<string>(nullable: true),
                    brief_details = table.Column<string>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    item_name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    stock_number = table.Column<int>(nullable: false),
                    remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "items");
        }
    }
}
