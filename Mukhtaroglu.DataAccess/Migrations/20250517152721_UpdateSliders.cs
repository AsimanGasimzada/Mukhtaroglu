using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mukhtaroglu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSliders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ButtonTitle",
                table: "SliderLanguages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ButtonTitle",
                table: "SliderLanguages");
        }
    }
}
