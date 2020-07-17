using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class Des : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Des",
                table: "Genres",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Des",
                table: "Genres");
        }
    }
}
