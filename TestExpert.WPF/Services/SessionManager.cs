using TestExpert.WPF.Models;
namespace TestExpert.WPF.Services;
public static class SessionManager { public static User? CurrentUser { get; private set; } public static void Login(User user)=>CurrentUser=user; public static void Logout()=>CurrentUser=null; public static bool IsAdmin=>CurrentUser?.Role.Name=="Admin"; public static bool IsTeacher=>CurrentUser?.Role.Name=="Teacher"; public static bool IsStudent=>CurrentUser?.Role.Name=="Student"; public static void RequireRole(string role){ if(CurrentUser?.Role.Name!=role) throw new UnauthorizedAccessException($"Требуется роль: {role}"); }}
