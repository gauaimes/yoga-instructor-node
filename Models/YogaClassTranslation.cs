namespace YogaInstructor.Api.Models
{
    public class YogaClassTranslation
    {
        public int Id { get; set; }
        public int YogaClassId { get; set; } // Link to the main yoga class
        public string LanguageCode { get; set; } = "en"; // "en", "hi" or "gu"

        // The translated fields
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        //public string ScientificBenefits { get; set; } = string.Empty;

        // Navigation Property (Tells .Net these two are linked)
        public YogaClass? YogaClass { get; set; }


    }
}
