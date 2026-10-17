# lab-01 — Assay


## Вимоги

- [.NET 8 SDK](https://dotnet.microsoft.com/download)

## Збірка і запуск

```bash
cd lab-01/AssayApp
dotnet restore
dotnet run
```

Застосунок відкриється на заставці, через 2.0 с без блокування UI-потоку
перейде на головний екран і сама заставка закриється.

## Структура

```
lab-01/
  AssayApp.sln
  README.md
  .gitignore
  AssayApp/
    AssayApp.csproj
    Program.cs
    App.axaml(.cs)
    Assets/
      logo-assay.png
    Controls/
      AssayLogo.axaml(.cs)
    Views/
      SplashWindow.axaml(.cs)
      MainWindow.axaml(.cs)
      AboutWindow.axaml(.cs)
```
