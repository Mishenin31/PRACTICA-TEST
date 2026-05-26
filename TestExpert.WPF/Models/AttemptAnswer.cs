namespace TestExpert.WPF.Models;
public class AttemptAnswer { public int Id { get; set; } public int AttemptId { get; set; } public ExamAttempt Attempt { get; set; } = null!; public int QuestionId { get; set; } public Question Question { get; set; } = null!; public int? SelectedOptionId { get; set; } public AnswerOption? SelectedOption { get; set; } public bool IsCorrect { get; set; } }
