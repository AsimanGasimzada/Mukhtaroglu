using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mukhtaroglu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _20250529001717_AddedSettingsSeedDatasPart3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Key" },
                values: new object[,]
                {
                    { 16, "FAQTitle" },
                    { 17, "FAQDescription" },
                    { 18, "Address" }
                });

            migrationBuilder.InsertData(
                table: "SettingLanguages",
                columns: new[] { "Id", "LanguageId", "SettingId", "Value" },
                values: new object[,]
                {
                    { 46, 1, 16, "Tez-tez verilən suallar" },
                    { 47, 2, 16, "Frequently Asked Questions" },
                    { 48, 3, 16, "Часто задаваемые вопросы" },
                    { 49, 1, 17, "Sizdən tez-tez soruşulan sualların cavablarını burada tapa bilərsiniz." },
                    { 50, 2, 17, "You can find answers to frequently asked questions here." },
                    { 51, 3, 17, "Вы можете найти ответы на часто задаваемые вопросы здесь." },
                    { 52, 1, 18, "Bakı, Azərbaycan" },
                    { 53, 2, 18, "Baku, Azerbaijan" },
                    { 54, 3, 18, "Баку, Азербайджан" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
