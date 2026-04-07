using Microsoft.EntityFrameworkCore;
using YogaInstructor.Api.Models;

namespace YogaInstructor.Api.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<YogaClass> YogaClasses => Set<YogaClass>();
        public DbSet<YogaClassTranslation> YogaClassTranslations => Set<YogaClassTranslation>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<YogaClass>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)"); // 18 digits total, 2 after the decimal point

            // First Seed Class
            modelBuilder.Entity<YogaClass>().HasData(

                new YogaClass
                {
                    Id = 1,
                    Price = 499.99m,
                    Intensity = 3,
                    Difficulty="Beginner",
                    ScientificBenefits= "Reduce Cortisol and Improves Spinal Mobility",
                    IsDoctorRecommended= true,
                    CreatedAt = new DateTime(2006, 1, 1, 0, 0, 0, DateTimeKind.Utc),

                });
            modelBuilder.Entity<YogaClassTranslation>().HasData(
                new YogaClassTranslation { Id = 1, YogaClassId = 1, LanguageCode = "en", Title = "Morning Flow", Description="A gental start to your day."},
                new YogaClassTranslation { Id = 2, YogaClassId = 1, LanguageCode = "hi", Title = "सुबह का प्रवाह", Description = "आपके दिन की एक कोमल शुरुआत।" },
                new YogaClassTranslation { Id = 3, YogaClassId = 1, LanguageCode = "gu", Title = "સવારનો પ્રવાહ", Description = "તમારા દિવસની નમ્ર શરૂઆત." }
                );

            base.OnModelCreating(modelBuilder);
        }

    }
}