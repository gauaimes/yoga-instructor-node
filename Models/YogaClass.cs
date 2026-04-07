namespace YogaInstructor.Api.Models
{
    public class YogaClass
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        
        public string Description { get; set; } = string.Empty;

        //SXO & User Experience Fields
        public string Difficulty { get; set; } = "Beginner"; // e.g., Beginner, Intermediate, Advanced
        public int Intensity { get; set; } // Scale of 1-10

        // GEO and AI Optimization (AIO/AEO) Fields
        public string ScientificBenefits { get; set; } = string.Empty; // e.g., "Improves flexibility, reduces stress"
        public bool IsDoctorRecommended { get; set; } = false; // E-E-A-T Signal for credibility

        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set;  } = DateTime.UtcNow;

        // The below line tell .Net that one yoga class can have many translations
        public ICollection<YogaClassTranslation> YogaClassTranslations { get; set; } = new List<YogaClassTranslation>();
    }
}
