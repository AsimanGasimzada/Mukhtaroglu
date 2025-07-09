using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mukhtaroglu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class BugFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AboutLanguages_LanguageId",
                table: "AboutLanguages");

            migrationBuilder.DropIndex(
                name: "IX_AboutLanguages_Title_Description",
                table: "AboutLanguages");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AboutLanguages",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000);

            migrationBuilder.CreateIndex(
                name: "IX_AboutLanguages_LanguageId_AboutId",
                table: "AboutLanguages",
                columns: new[] { "LanguageId", "AboutId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AboutLanguages_LanguageId_AboutId",
                table: "AboutLanguages");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AboutLanguages",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 5000);

            migrationBuilder.CreateIndex(
                name: "IX_AboutLanguages_LanguageId",
                table: "AboutLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutLanguages_Title_Description",
                table: "AboutLanguages",
                columns: new[] { "Title", "Description" },
                unique: true);
        }
    }
}
