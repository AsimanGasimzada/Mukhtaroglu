using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mukhtaroglu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedSettingsSeedDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Key" },
                values: new object[,]
                {
                    { 1, "CustomerCount" },
                    { 2, "ProjectCount" },
                    { 3, "YearsOfExperience" },
                    { 4, "CerificateCount" },
                    { 5, "FacebookLink" },
                    { 6, "InstagramLink" },
                    { 7, "TiktokLink" },
                    { 8, "FooterDescription" },
                    { 9, "PhoneNumber" },
                    { 10, "Email" }
                });

            migrationBuilder.InsertData(
                table: "SettingLanguages",
                columns: new[] { "Id", "LanguageId", "SettingId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "100" },
                    { 2, 2, 1, "100" },
                    { 3, 3, 1, "100" },
                    { 4, 1, 2, "250" },
                    { 5, 2, 2, "250" },
                    { 6, 3, 2, "250" },
                    { 7, 1, 3, "10" },
                    { 8, 2, 3, "10" },
                    { 9, 3, 3, "10" },
                    { 10, 1, 4, "30" },
                    { 11, 2, 4, "30" },
                    { 12, 3, 4, "30" },
                    { 13, 1, 5, "https://facebook.com/example" },
                    { 14, 2, 5, "https://facebook.com/example" },
                    { 15, 3, 5, "https://facebook.com/example" },
                    { 16, 1, 6, "https://instagram.com/example" },
                    { 17, 2, 6, "https://instagram.com/example" },
                    { 18, 3, 6, "https://instagram.com/example" },
                    { 19, 1, 7, "https://tiktok.com/@example" },
                    { 20, 2, 7, "https://tiktok.com/@example" },
                    { 21, 3, 7, "https://tiktok.com/@example" },
                    { 22, 1, 8, "Biz sizin uğurunuz üçün çalışırıq." },
                    { 23, 2, 8, "We work for your success." },
                    { 24, 3, 8, "Мы работаем для вашего успеха." },
                    { 25, 1, 9, "+994 51 000 00 00" },
                    { 26, 2, 9, "+994 51 000 00 00" },
                    { 27, 3, 9, "+994 51 000 00 00" },
                    { 28, 1, 10, "info@example.com" },
                    { 29, 2, 10, "info@example.com" },
                    { 30, 3, 10, "info@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
