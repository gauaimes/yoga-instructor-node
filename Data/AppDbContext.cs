using Microsoft.EntityFrameworkCore;
using YogaInstructor.Api.Models;

namespace YogaInstructor.Api.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<YogaClass> YogaClasses => Set<YogaClass>();
        public DbSet<YogaClassTranslation> YogaClassTranslations => Set<YogaClassTranslation>();

    }
}
