using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class deleteforum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discussions_Forums_ForumId",
                table: "Discussions");

            migrationBuilder.DropTable(
                name: "Forums");

            migrationBuilder.DropIndex(
                name: "IX_Discussions_ForumId",
                table: "Discussions");

            migrationBuilder.DropColumn(
                name: "ForumId",
                table: "Discussions");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Discussions",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Discussions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "ForumId",
                table: "Discussions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Forums",
                columns: table => new
                {
                    ForumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums", x => x.ForumId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Discussions_ForumId",
                table: "Discussions",
                column: "ForumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Discussions_Forums_ForumId",
                table: "Discussions",
                column: "ForumId",
                principalTable: "Forums",
                principalColumn: "ForumId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
