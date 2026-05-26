namespace TestExpert.WPF.Models;
public class TeacherGroup { public int TeacherId { get; set; } public User Teacher { get; set; } = null!; public int GroupId { get; set; } public Group Group { get; set; } = null!; }
