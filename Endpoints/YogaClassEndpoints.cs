using Microsoft.EntityFrameworkCore;
using YogaInstructor.Api.Data;

namespace YogaInstructor.Api.Endpoints
{
    public static class YogaClassEndpoints
    {
        public static void MapYogaClassEndpoints(this IEndpointRouteBuilder app)
        {
            // This endpoint gets all the class in a specific language (en, hi, gu)

            app.MapGet("/api/classes", async (string? lang, AppDbContext db) =>
            {
                var targetLang = lang ?? "en";
                var classes = await db.YogaClasses
                    .AsNoTracking()
                    .Select(c => new
                    {
                        c.Id,
                        c.Price,
                        c.Intensity,
                        c.Difficulty,
                        // Here is the "Magic": we find the translation matches the language parameter
                        ScientificBenefits = c.ScientificBenefits,

                        Details = c.YogaClassTranslations
                        .Where(t => t.LanguageCode == targetLang)
                        .Select(t => new { t.Title, t.Description})
                        .FirstOrDefault() // We take the first match, or null if not found
                        ?? c.YogaClassTranslations
                        .Where(t => t.LanguageCode == "en") // Fallback to English if the requested language is not available
                        .Select(t => new { t.Title, t.Description})
                        .FirstOrDefault()

                    })
                    .ToListAsync();

                return Results.Ok(classes);
            })
            .WithName("GetYogaClasses")
            .WithSummary("Get all yoga classes in English, Hindi, or Gujarati")
            .WithDescription("Retrieves a list of yoga classes with local language fallbacks.");

        }
    }
}
