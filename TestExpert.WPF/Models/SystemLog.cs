namespace TestExpert.WPF.Models;
public class SystemLog { public int Id { get; set; } public int? UserId { get; set; } public string Action { get; set; } = null!; public string Details { get; set; } = string.Empty; public DateTime OccurredAt { get; set; } = DateTime.Now; }
