using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationSystem.Models
{
    public class StudentAnswersTable
    {
        [Key]
        public int answerId { get; set; }

        [Required]
        public string? stronglyAgree { get; set; }
        [Required]
        public string? agree { get; set; }
        [Required]
        public string? neutral { get; set; }
        [Required]
        public string? disagree { get; set; }
        [Required]
        public string? stronglyDisagree { get; set; }

        [ForeignKey("studentNumber")]
        public int studentFK { get; set; }

        [ForeignKey("professorId")]
        public int professorFK { get; set; }

        public StudentTableModel? studentNumber { get; set; }

        public ProfessorTableModel? professorId { get; set; }
    }
}