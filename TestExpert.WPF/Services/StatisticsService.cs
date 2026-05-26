using Microsoft.EntityFrameworkCore; using TestExpert.WPF.Data;
namespace TestExpert.WPF.Services;
public class StatisticsService { private readonly AppDbContext _db; public StatisticsService(AppDbContext db)=>_db=db;
public List<(string Name,double Avg)> GetGroupAverages(int teacherId,int groupId){ var allowed=_db.TeacherGroups.Any(t=>t.TeacherId==teacherId&&t.GroupId==groupId); if(!allowed) throw new UnauthorizedAccessException(); return _db.Users.Include(u=>u.Attempts).Where(u=>u.GroupId==groupId&&u.Role.Name=="Student").Select(u=>new ValueTuple<string,double>(u.FullName,u.Attempts.Where(a=>a.Status!="InProgress"&&a.MaxScore>0).Select(a=>a.Score/a.MaxScore*100).DefaultIfEmpty(0).Average())).ToList(); }}
