using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mukhtaroglu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedLanguageSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "Languages",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, "AZE", "https://res.cloudinary.com/dlilcwizx/image/upload/v1730241623/motordoctor.az/fajaznl6ilmlbmo05xbw.png", "Azerbaijani" },
                    { 2, "ENG", "https://res.cloudinary.com/dlilcwizx/image/upload/v1730241623/motordoctor.az/mygg6rnd9rkxwc6vlljx.png", "English" },
                    { 3, "RUS", "https://res.cloudinary.com/dlilcwizx/image/upload/v1730241623/motordoctor.az/upkqfbyfpy7rvmjdwfsm.png", "Russian" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "Languages",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);
        }
    }
}
