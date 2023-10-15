using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class StudentAnswersTable
    {
        [Key]
        public int answerId { get; set; }

        public int studentNumber { get; set; }
        public string? lastName { get; set; }
        public string? course { get; set; }
        public int yearLevel { get; set; }

        [Required]
        public string? answerOne { get; set; }
        [Required]
        public string? answerTwo { get; set; }
        [Required]
        public string? answerThree { get; set; }
        [Required]
        public string? answerFour { get; set; }
        [Required]
        public string? answerFive { get; set; }

        public int professorId { get; set; }

        [ForeignKey("studentNumber")]
        public StudentTableModel? Student { get; set; }
        [ForeignKey("professorId")]
        public ProfessorTableModel? Professor { get; set; }
        public DateTime dateEvaluated { get; set; }
    }
}
