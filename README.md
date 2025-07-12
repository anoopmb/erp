# ERP App Skeleton

This repository contains a minimal WPF application skeleton targeting .NET 7 and demonstrating MVVM Toolkit usage with dependency injection. It is **not** a full ERP implementation, but a starting point for building one.

## Prerequisites
- Windows with .NET 7 SDK and workloads installed (WPF is only supported on Windows).

## Project Structure
- `ErpApp` - WPF project containing the `App`, `MainWindow`, and a simple `MainViewModel`.
- `ErpApp.sln` - Solution file.

## Building
```
dotnet restore
# Build on Windows
```

## Notes
This skeleton illustrates how to wire up dependency injection and MVVM using the CommunityToolkit.Mvvm package. Expand with additional views, view models, and database logic as needed.
