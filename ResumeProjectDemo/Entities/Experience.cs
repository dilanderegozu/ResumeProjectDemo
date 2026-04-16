using System.ComponentModel.DataAnnotations;

namespace ResumeProjectDemo.Entities
{
    public class Experience
    {
        public int ExperienceId { get; set; }

        [Required(ErrorMessage = "Şirket adı ve unvan zorunludur.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Çalışma tarihi zorunludur.")]
        public string WorkDate { get; set; }

        [Required(ErrorMessage = "Açıklama zorunludur.")]
        public string Description { get; set; }
    }
}
