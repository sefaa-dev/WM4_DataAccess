using Microsoft.EntityFrameworkCore.Migrations;

namespace KuzeyCodeFirst.Migrations
{
    public partial class version2581555 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Silinicek",
                table: "Kategoriler");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Silinicek",
                table: "Kategoriler",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
