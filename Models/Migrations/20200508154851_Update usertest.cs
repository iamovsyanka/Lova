using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class Updateusertest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "UserTests",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<string>(
                name: "TestName",
                table: "UserTests",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestName",
                table: "UserTests");

            migrationBuilder.AlterColumn<float>(
                name: "Result",
                table: "UserTests",
                type: "real",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
