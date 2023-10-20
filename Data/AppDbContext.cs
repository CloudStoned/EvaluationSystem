using EvaluationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EvaluationSystem.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }
        public DbSet<StudentTableModel> Students { get; set; }

        public DbSet<ProfessorTableModel> Professors { get; set; }  
        public DbSet<StudentAnswersTable> Answers { get; set; }
    }
}
