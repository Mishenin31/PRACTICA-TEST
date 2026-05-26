using Microsoft.EntityFrameworkCore;
using TestExpert.WPF.Models;

namespace TestExpert.WPF.Data;

public class AppDbContext : DbContext
{
    public DbSet<Role> Roles => Set<Role>(); public DbSet<Group> Groups => Set<Group>(); public DbSet<User> Users => Set<User>();
    public DbSet<TeacherGroup> TeacherGroups => Set<TeacherGroup>(); public DbSet<Subject> Subjects => Set<Subject>(); public DbSet<Exam> Exams => Set<Exam>();
    public DbSet<Question> Questions => Set<Question>(); public DbSet<AnswerOption> AnswerOptions => Set<AnswerOption>(); public DbSet<ExamQuestion> ExamQuestions => Set<ExamQuestion>();
    public DbSet<ExamAttempt> ExamAttempts => Set<ExamAttempt>(); public DbSet<AttemptAnswer> AttemptAnswers => Set<AttemptAnswer>(); public DbSet<SystemLog> SystemLogs => Set<SystemLog>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TestExpertDb;Trusted_Connection=True;TrustServerCertificate=True;");
    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<TeacherGroup>().HasKey(tg => new { tg.TeacherId, tg.GroupId });
        mb.Entity<ExamQuestion>().HasKey(eq => new { eq.ExamId, eq.QuestionId });
        mb.Entity<Exam>().HasOne(e => e.CreatedByTeacher).WithMany().HasForeignKey(e => e.CreatedByTeacherId).OnDelete(DeleteBehavior.Restrict);
        mb.Entity<ExamAttempt>().HasOne(a => a.Student).WithMany(u => u.Attempts).HasForeignKey(a => a.StudentId).OnDelete(DeleteBehavior.Restrict);
    }
}
