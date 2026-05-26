# TestExpert.WPF

## Запуск
1. `dotnet restore`
2. `dotnet ef migrations add Init --project TestExpert.WPF`
3. `dotnet ef database update --project TestExpert.WPF`
4. Выполнить `Scripts/SeedData.sql` в SQL Server.
5. `dotnet run --project TestExpert.WPF`

Логины создаются seed-скриптом.
