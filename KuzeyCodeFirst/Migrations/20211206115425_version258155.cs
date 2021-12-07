using Microsoft.EntityFrameworkCore.Migrations;

namespace KuzeyCodeFirst.Migrations
{
    public partial class version258155 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Silinicek",
                table: "Kategoriler",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Silinicek",
                table: "Kategoriler");
        }
    }
}
