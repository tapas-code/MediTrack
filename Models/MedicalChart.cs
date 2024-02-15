using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MediTrack.Models
{
    public class MedicalChart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChartID { get; set; }

        [Required(ErrorMessage = "Patient ID is required")]
        public int PatientID { get; set; }

        [Required(ErrorMessage = "Chart type is required")]
        [StringLength(20, ErrorMessage = "Chart type must be at most 20 characters long")]
        public string ChartType { get; set; } = string.Empty;

        [Required(ErrorMessage = "Chart URL is required")]
        [DataType(DataType.Url, ErrorMessage = "Invalid URL format")]
        public string ChartURL { get; set; } = string.Empty;

    }
}
