using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YogaInstructor.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialYogaDataLanguageCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "YogaClasses",
                columns: new[] { "Id", "CreatedAt", "Description", "Difficulty", "Intensity", "IsDoctorRecommended", "Price", "ScientificBenefits", "Title" },
                values: new object[] { 1, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "", "Beginner", 3, true, 499.99m, "Reduce Cortisol and Improves Spinal Mobility", "" });

            migrationBuilder.InsertData(
                table: "YogaClassTranslations",
                columns: new[] { "Id", "Description", "LanguageCode", "ScientificBenefits", "Title", "YogaClassId" },
                values: new object[,]
                {
                    { 1, "A gental start to your day.", "en", "", "Morning Flow", 1 },
                    { 2, "आपके दिन की एक कोमल शुरुआत।", "hi", "", "सुबह का प्रवाह", 1 },
                    { 3, "તમારા દિવસની નમ્ર શરૂઆત.", "gu", "", "સવારનો પ્રવાહ", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "YogaClassTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "YogaClassTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "YogaClassTranslations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "YogaClasses",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
