using Microsoft.EntityFrameworkCore.Migrations;

namespace USALawns.Migrations
{
    public partial class addJobandType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Task",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "Visit",
                table: "Job");

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Job");

            migrationBuilder.AlterColumn<bool>(
                name: "Job",
                table: "Job",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Task",
                table: "Job",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visit",
                table: "Job",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
