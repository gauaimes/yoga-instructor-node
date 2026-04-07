using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YogaInstructor.Api.Migrations
{
    /// <inheritdoc />
    public partial class FinalDataCleanUp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScientificBenefits",
                table: "YogaClassTranslations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ScientificBenefits",
                table: "YogaClassTranslations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "YogaClassTranslations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ScientificBenefits",
                value: "");

            migrationBuilder.UpdateData(
                table: "YogaClassTranslations",
                keyColumn: "Id",
                keyValue: 2,
                column: "ScientificBenefits",
                value: "");

            migrationBuilder.UpdateData(
                table: "YogaClassTranslations",
                keyColumn: "Id",
                keyValue: 3,
                column: "ScientificBenefits",
                value: "");
        }
    }
}
