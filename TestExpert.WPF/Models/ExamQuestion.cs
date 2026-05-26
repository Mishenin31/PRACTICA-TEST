namespace TestExpert.WPF.Models;
public class ExamQuestion { public int ExamId { get; set; } public Exam Exam { get; set; } = null!; public int QuestionId { get; set; } public Question Question { get; set; } = null!; public int OrderIndex { get; set; } }
