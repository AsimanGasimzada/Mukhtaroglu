using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mukhtaroglu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RepairSettingSeedDatas : Migration
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
                    { 2, "ProductCount" },
                    { 3, "MagazineCount" },
                    { 4, "CerificateCount" },
                    { 5, "FacebookLink" },
                    { 6, "InstagramLink" },
                    { 7, "TiktokLink" },
                    { 8, "FooterDescription" },
                    { 9, "PhoneNumber" },
                    { 10, "Email" },
                    { 11, "WhatsappLink" },
                    { 12, "AboutTitle" },
                    { 13, "AboutDescription" },
                    { 14, "ContactTitle" },
                    { 15, "ContactDescription" },
                    { 16, "FAQTitle" },
                    { 17, "FAQDescription" },
                    { 18, "Address" },
                    { 19, "HomeSection1Title" },
                    { 21, "HomeSection2Title" },
                    { 22, "HomeSection2Description" },
                    { 23, "HomeSection3Title" },
                    { 24, "HomeSection3Description" },
                    { 25, "HomeSection4Title" },
                    { 26, "HomeSection4Description" },
                    { 27, "HomeSection5Title" },
                    { 28, "HomeSection5Description" },
                    { 29, "ContactFormTitle" },
                    { 30, "ContactFormDescription" }
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
                    { 30, 3, 10, "info@example.com" },
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
                    { 45, 3, 15, "Свяжитесь с нами, и мы ответим на ваши вопросы." },
                    { 46, 1, 16, "Tez-tez verilən suallar" },
                    { 47, 2, 16, "Frequently Asked Questions" },
                    { 48, 3, 16, "Часто задаваемые вопросы" },
                    { 49, 1, 17, "Sizdən tez-tez soruşulan sualların cavablarını burada tapa bilərsiniz." },
                    { 50, 2, 17, "You can find answers to frequently asked questions here." },
                    { 51, 3, 17, "Вы можете найти ответы на часто задаваемые вопросы здесь." },
                    { 52, 1, 18, "Bakı, Azərbaycan" },
                    { 53, 2, 18, "Baku, Azerbaijan" },
                    { 54, 3, 18, "Баку, Азербайджан" },
                    { 55, 1, 19, "Bizim Uğurumuz" },
                    { 56, 2, 19, "Our Success" },
                    { 57, 3, 19, "Наш успех" },
                    { 61, 1, 21, "Bizim Servislərimiz" },
                    { 62, 2, 21, "Our Services" },
                    { 63, 3, 21, "Наши услуги" },
                    { 64, 1, 22, "Biz müştərilərimizə ən yaxşı xidmətləri təqdim edirik." },
                    { 65, 2, 22, "We provide the best services to our customers." },
                    { 66, 3, 22, "Мы предоставляем лучшие услуги нашим клиентам." },
                    { 67, 1, 23, "Müştəri Rəyləri" },
                    { 68, 2, 23, "Customer Reviews" },
                    { 69, 3, 23, "Отзывы клиентов" },
                    { 70, 1, 24, "Müştərilərimizin rəyləri bizim üçün çox önəmlidir." },
                    { 71, 2, 24, "Customer reviews are very important to us." },
                    { 72, 3, 24, "Отзывы клиентов очень важны для нас." },
                    { 73, 1, 25, "Əlaqə Forması" },
                    { 74, 2, 25, "Contact Form" },
                    { 75, 3, 25, "Контактная форма" },
                    { 76, 1, 26, "Bizimlə əlaqə saxlamaq üçün aşağıdakı formu doldurun." },
                    { 77, 2, 26, "Fill out the form below to contact us." },
                    { 78, 3, 26, "Заполните форму ниже, чтобы связаться с нами." },
                    { 79, 1, 27, "Əlaqə Məlumatları" },
                    { 80, 2, 27, "Contact Information" },
                    { 81, 3, 27, "Контактная информация" },
                    { 82, 1, 28, "Bizimlə əlaqə saxlamaq üçün aşağıdakı məlumatlardan istifadə edin." },
                    { 83, 2, 28, "Use the information below to contact us." },
                    { 84, 3, 28, "Используйте информацию ниже, чтобы связаться с нами." },
                    { 85, 1, 29, "Əlaqə Forması" },
                    { 86, 2, 29, "Contact Form" },
                    { 87, 3, 29, "Контактная форма" },
                    { 88, 1, 30, "Bizimlə əlaqə saxlamaq üçün aşağıdakı formu doldurun." },
                    { 89, 2, 30, "Fill out the form below to contact us." },
                    { 90, 3, 30, "Заполните форму ниже, чтобы связаться с нами." }
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
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "SettingLanguages",
                keyColumn: "Id",
                keyValue: 90);

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

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
