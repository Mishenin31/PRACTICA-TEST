namespace TestExpert.WPF.Models;
public class Subject { public int Id { get; set; } public string Name { get; set; } = null!; public ICollection<Exam> Exams { get; set; } = new List<Exam>(); public ICollection<Question> Questions { get; set; } = new List<Question>(); }
