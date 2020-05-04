using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class Addtextindiscussion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Discussions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Discussions");
        }
    }
}
