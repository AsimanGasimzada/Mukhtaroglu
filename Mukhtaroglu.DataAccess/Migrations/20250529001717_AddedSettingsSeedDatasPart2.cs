using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mukhtaroglu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedSettingsSeedDatasPart2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Key" },
                values: new object[,]
                {
                    { 11, "WhatsappLink" },
                    { 12, "AboutTitle" },
                    { 13, "AboutDescription" },
                    { 14, "ContactTitle" },
                    { 15, "ContactDescription" }
                });

            migrationBuilder.InsertData(
                table: "SettingLanguages",
                columns: new[] { "Id", "LanguageId", "SettingId", "Value" },
                values: new object[,]
                {
                    { 31, 1, 11, "https://wa.me/994510000000" },
                    { 32, 2, 11, "https://wa.me/994510000000" },
                    { 33, 3, 11, "https://wa.me/994510000000" },
                    { 34, 1, 12, "Haqqımızda" },
                    { 35, 2, 12, "About Us" },
                    { 36, 3, 12, "О нас" },
                    { 37, 1, 13, "Biz sizin uğurunuz üçün çalışırıq. Bizimlə əlaqə saxlayın." },
                    { 38, 2, 13, "We work for your success. Contact us." },
                    { 39, 3, 13, "Мы работаем для вашего успеха. Свяжитесь с нами." },
                    { 40, 1, 14, "Əlaqə" },
                    { 41, 2, 14, "Contact" },
                    { 42, 3, 14, "Контакт" },
                    { 43, 1, 15, "Bizimlə əlaqə saxlayın və suallarınızı cavablandıraq." },
                    { 44, 2, 15, "Contact us and we will answer your questions." },
                    { 45, 3, 15, "Свяжитесь с нами, и мы ответим на ваши вопросы." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
