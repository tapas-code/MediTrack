using System.ComponentModel.DataAnnotations;

namespace MediTrack.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; } = string.Empty;
        public List<Patient> AllPatients { get; set; }
        public Patient patient { get; set; }
        public List<MedicalChart> AllMedicalCharts { get; set;}
        public MedicalChart medicalChart { get; set; }
    }
}
