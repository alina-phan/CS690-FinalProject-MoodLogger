# Developer Documentation for MoodLogger

## 🔍 Project Overview
Emma's Wellness Tracker is a .NET 9 console application that allows users to log daily moods, activities, sleep quality, food, and weather influences. The goal is to promote self-awareness and wellness tracking through simple, repeatable journaling.

---

## 🧱 Project Structure
- `Program.cs`: Main entry point.
- `WellnessLog.cs`: Represents a daily wellness entry.
- `WellnessTracker.cs`: Core logic for adding, retrieving, saving, and loading logs.
- `LogManager.cs`: Handles file operations (`logs.json`).
- `logs.json`: Stores all the mood log data in JSON format.
- `MoodLogger.Tests/`: Contains unit tests for LogManager and core logic.

---

## 🧪 Testing
- **Framework**: xUnit with Coverlet for code coverage.
- **Test Files**: `LogManagerTests.cs`, `WellnessTrackerTests.cs`
- **Run Command**:
  ```bash
  dotnet test
  ```
- ✅ All tests pass as of final commit.

---

## 🚧 Known Limitations
- Weather data is manually entered, not fetched from API.
- No mood trend graphing or CSV export.
- Input validation is minimal (happy path assumed).

--- 

## 📦 Dependencies
- .NET 9.0
- System.Text.Json
- xUnit, coverlet.collector

## 🚀 Getting Started
To run locally:
```bash
cd MoodLoggerProject/MoodLogger
dotnet run
```
To run tests:
```bash
cd CS690-FinalProject-MoodLogger
dotnet test
```