using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class StudentTableModel
    {
        [Key]
        public int studentNumber { get; set; }
        [Required]
        public string? studentFirstName { get; set; }
        [Required]
        public string? studentLastName { get; set; }
        [Required]
        public string? studentCourse { get; set; }
        [Required]
        public int studentYearLevel { get; set; }
    }
}
