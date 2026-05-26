namespace TestExpert.WPF.Models;
public class AnswerOption { public int Id { get; set; } public int QuestionId { get; set; } public Question Question { get; set; } = null!; public string Text { get; set; } = null!; public bool IsCorrect { get; set; } }
