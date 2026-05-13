namespace ResumeProjectDemo.Entities
{
    public class About
    {
        public int AboutId { get; set; }
        public string NameSurname { get; set; }
        public string  Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        // Eğitim Bölümü (Görselde 2 adet var)
        public string EducationTitle1 { get; set; }
        public string EducationDate1 { get; set; }
        public string EducationTitle2 { get; set; }
        public string EducationDate2 { get; set; }

        // Hakkımda içindeki Özet Deneyim/Başarı Bölümü (Görselde 2 adet var)
        public string SummaryExperienceTitle1 { get; set; }
        public string SummaryExperienceDesc1 { get; set; }
        public string SummaryExperienceTitle2 { get; set; }
        public string SummaryExperienceDesc2 { get; set; }


    }
}
