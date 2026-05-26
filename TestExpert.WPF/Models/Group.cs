namespace TestExpert.WPF.Models;
public class Group { public int Id { get; set; } public string Name { get; set; } = null!; public int Course { get; set; } public string Specialty { get; set; } = null!; public ICollection<User> Students { get; set; } = new List<User>(); public ICollection<TeacherGroup> TeacherGroups { get; set; } = new List<TeacherGroup>(); }
