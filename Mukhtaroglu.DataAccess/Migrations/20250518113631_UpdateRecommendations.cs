using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mukhtaroglu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRecommendations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "RecommendationLanguages");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Recommendations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddCheckConstraint(
                name: "CK_Recommendations_Rating_Constraint",
                table: "Recommendations",
                sql: "[Rating] >= 0 AND [Rating] <= 5");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Recommendations_Rating_Constraint",
                table: "Recommendations");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Recommendations");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "RecommendationLanguages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
