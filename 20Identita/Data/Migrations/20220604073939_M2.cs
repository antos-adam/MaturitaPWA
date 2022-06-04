using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _20Identita.Data.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Jmeno",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prijmeni",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Jmeno",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Prijmeni",
                table: "AspNetUsers");
        }
    }
}
