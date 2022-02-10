using Microsoft.EntityFrameworkCore.Migrations;

namespace USALawns.Migrations
{
    public partial class Addedrestructuredatabasebasic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Estimates");

            migrationBuilder.DropColumn(
                name: "Job",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Job",
                table: "Job",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Job",
                table: "Estimates",
                newName: "Description");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Job",
                newName: "Job");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Estimates",
                newName: "Job");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Estimates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Job",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
