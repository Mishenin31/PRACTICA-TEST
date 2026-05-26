namespace TestExpert.WPF.Helpers; public static class GradeHelper { public static string ToGrade(double pct)=>pct>=90?"A":pct>=75?"B":pct>=60?"C":"F"; }
