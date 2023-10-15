using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Models
{
    public class ProfessorTableModel
    {
        [Key]
        public int professorId { get; set; }
        [Required]
        public string? professorFirstName { get; set; }
        [Required]
        public string? professorLastName { get; set; }
        public DateTime dateCreated { get; set; } = DateTime.Now;
    }
}
