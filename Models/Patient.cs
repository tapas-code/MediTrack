using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediTrack.Models
{
    public class Patient
    {
        [Key] // Defines the field as primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Defines the field as auto incrementing
        public int PatientID { get; set; }

        [Required(ErrorMessage = "Medical Record Number (MRN) is required.")] // Defines the field as required and cannot be empty
        [StringLength(20, ErrorMessage = "MRN must be at most 20 characters long.")] // Defines max length of the field = 20
        public string MRN { get; set; } = string.Empty;

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(100, ErrorMessage = "First Name must be at most 100 characters long.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(100, ErrorMessage = "Last Name must be at most 100 characters long.")]
        public string LastName { get; set; } = string.Empty;

        public string PatientName => $"{FirstName} {LastName}";

        [Required(ErrorMessage = "Date of birth is required.")]
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        [StringLength(20, ErrorMessage = "Gender must be at most 20 characters long.")]
        public string Gender { get; set; } = string.Empty;
    }
}
