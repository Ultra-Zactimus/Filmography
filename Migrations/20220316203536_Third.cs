using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Filmography.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieWiki_Composers_ComposerId",
                table: "MovieWiki");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieWiki_Directors_DirectorId",
                table: "MovieWiki");

            migrationBuilder.DropTable(
                name: "Composers");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropIndex(
                name: "IX_MovieWiki_ComposerId",
                table: "MovieWiki");

            migrationBuilder.DropIndex(
                name: "IX_MovieWiki_DirectorId",
                table: "MovieWiki");

            migrationBuilder.DropColumn(
                name: "ComposerId",
                table: "MovieWiki");

            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "MovieWiki");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComposerId",
                table: "MovieWiki",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DirectorId",
                table: "MovieWiki",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Composers",
                columns: table => new
                {
                    ComposerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ComposerName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Composers", x => x.ComposerId);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    DirectorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DirectorName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.DirectorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieWiki_ComposerId",
                table: "MovieWiki",
                column: "ComposerId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieWiki_DirectorId",
                table: "MovieWiki",
                column: "DirectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieWiki_Composers_ComposerId",
                table: "MovieWiki",
                column: "ComposerId",
                principalTable: "Composers",
                principalColumn: "ComposerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieWiki_Directors_DirectorId",
                table: "MovieWiki",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "DirectorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
