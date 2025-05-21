using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mukhtaroglu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedFAQs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.Id);
                    table.CheckConstraint("CK_FAQs_Order_Constraint", "[Order] >= 0 ");
                });

            migrationBuilder.CreateTable(
                name: "FAQLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    FAQId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FAQLanguages_FAQs_FAQId",
                        column: x => x.FAQId,
                        principalTable: "FAQs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FAQLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FAQLanguages_FAQId_LanguageId",
                table: "FAQLanguages",
                columns: new[] { "FAQId", "LanguageId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FAQLanguages_LanguageId",
                table: "FAQLanguages",
                column: "LanguageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQLanguages");

            migrationBuilder.DropTable(
                name: "FAQs");
        }
    }
}
