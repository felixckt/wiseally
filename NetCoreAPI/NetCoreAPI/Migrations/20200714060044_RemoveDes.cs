using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class RemoveDes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Des",
                table: "Genres");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Des",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
