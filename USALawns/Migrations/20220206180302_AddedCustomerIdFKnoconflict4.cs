using Microsoft.EntityFrameworkCore.Migrations;

namespace USALawns.Migrations
{
    public partial class AddedCustomerIdFKnoconflict4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Customers");
        }
    }
}
