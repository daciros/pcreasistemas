using Microsoft.EntityFrameworkCore.Migrations;

namespace pruebacs1.Data.Migrations
{
    public partial class DataFacturing1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "TableUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "TableUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "TableUsers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "TableUsers");
        }
    }
}
