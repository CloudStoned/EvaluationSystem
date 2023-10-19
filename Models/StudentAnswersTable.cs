using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationSystem.Models
{
    public class StudentAnswersTable
    {
        [Key]
        public int answerId { get; set; }

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

        [ForeignKey("studentNumber")]
        public int studentFK { get; set; }

        [ForeignKey("professorId")]
        public int professorFK { get; set; }

        public StudentTableModel? studentNumber { get; set; }

        public ProfessorTableModel? professorId { get; set; }
    }
}