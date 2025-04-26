# 🌤️ CS690 Final Project – MoodLogger

![.NET Tests](https://github.com/alina-phan/CS690-FinalProject-MoodLogger/actions/workflows/dotnet-test.yml/badge.svg?nocache=latest)

This project is a wellness tracking console application...

---

## 📖 Scenario: *"A Day in the Life of Emma"*

Emma wakes up tired and irritable, unsure whether it’s lack of sleep or skipping a workout. Throughout the day, she wonders if her mood could be tied to things like what she eats, the weather, or how active she is. Inspired by a coworker’s suggestion and a blog post on wellness tracking, Emma decides it’s time to find patterns in her lifestyle. But doing it all manually feels overwhelming — she needs a simple, consistent way to log her daily experience.

That’s where this app comes in.

---

## 🎯 Business Requirement

> Develop a console-based C# application using .NET 8 that enables users to track and review lifestyle-related data (mood, sleep, food, activities, and weather) with the goal of identifying patterns that affect emotional health.

---

## ✅ Use Cases

### 🥗 UC1: Food Logging  
Emma records her daily food intake to observe how her dietary habits influence mood and energy levels.

### 🛌 UC2: Sleep Logging  
Emma logs how many hours she slept the night before to evaluate how sleep correlates with emotional stability.

### 🏃 UC3: Activity Logging  
Emma notes key activities like workouts, junk food, or screen time that could impact her mental state.

### 🌧️ UC4: Weather Logging  
Emma tracks environmental conditions (sun, rain, etc.) to explore how weather may affect her mood.

### 📈 UC5: Mood Logging & Trends  
Emma logs her mood and later reviews trends like:  
- **Sleep vs. Mood**  
- **Sunny Days vs. Mood**  
- **Activity vs. Mood**


---

## ⚙️ Technologies

- 💻 **C#**
- 🧱 **.NET 8 SDK**
- 🖥️ **Console-based UI**
- 📁 **File-based logging (JSON or TXT)**

---

## 📌 Constraints

- Must use .NET Version 8
- Console-based interface only (no GUI)
- Functional logging for all use cases
- Must support persistent logs across sessions

---

## 🧪 Status

| Feature | Status |
|--------|--------|
| Food Logging | ✅ Implemented |
| Sleep Logging | ✅ Implemented |
| Activity Logging | ✅ Implemented |
| Weather Logging | ✅ Implemented |
| Mood Logging + Trends | 🚧 In Progress |

---

## ✅ Implemented Features

Below is a summary of all features and enhancements tracked through GitHub Issues and completed for this project.

### 🔧 Functional Features

| Feature | Description |
|--------|-------------|
| Mood Logging | Users can log their mood for the day |
| Sleep Logging | Users can log their sleep hours |
| Daily Activities | Users can log daily activities |
| Food Intake | Users can log their food intake |
| Weather Logging | Users can log current weather conditions |
| View Past Logs | Users can view historical mood/wellness entries |
| Data Persistence | Entries persist across sessions via file saving |

---

### ⚙️ Non-Functional Requirements

| Feature | Description |
|--------|-------------|
| Performance | App responds within 2 seconds |
| Modular Codebase | Code organized into structured, reusable classes |
| GitIgnore Setup | Data output files excluded from Git version control |

---

### 🧪 Testing & Deployment

| Feature | Description |
|--------|-------------|
| Unit Testing | Core functions are validated with xUnit tests |
| Deployment.md | Contains setup instructions and usage guide |

📂 For more detail, see the [Wiki Issue Tracker Summary](https://github.com/alina-phan/CS690-FinalProject-MoodLogger/wiki/Issue-Tracker-Summary)


---

## 👥 Author

** Alina Phan**  
CS690 - Software Architecture & Design  
Ball State University

---

## 🛠️ Development Notes

To open and run this project in **Visual Studio**:

1. Clone the repository:
   ```bash
   git clone https://github.com/alina-phan/CS690-FinalProject-MoodLogger.git
   ```

2. Open the solution file:
`MoodLoggerProject.sln`

This will load both the main application and the test project.

## 📁 Projects included:

- MoodLogger – main console app (C#)

- MoodLogger.Tests – xUnit test project


---

## 🚀 2. Optional: Automate Tests via Terminal

Now that everything is tracked by the solution file, you can run **all tests** across the solution from the root like this:

```bash
dotnet test MoodLoggerProject.sln
```
This will:

- Build the solution

- Run all xUnit tests in MoodLogger.Tests

- Print a pass/fail summary


# Missing Points and Maintenance Notes

## 🚧 Functionality Gaps
- **Weather influence tracking**: Planned but not fully integrated into mood analysis.
- **Graphical trend/reporting features**: Not implemented due to console limitations; future versions may include charts or export to CSV.
- **User data segmentation**: Currently supports one user/session. No multi-user support.
- **Error recovery**: Limited handling for invalid inputs or corrupted `logs.json`.

## 🧪 Testing Gaps
- Unit tests focus on `WellnessTracker` and `LogManager`.
- **No integration or end-to-end tests** for full logging flow.
- **Console interaction** not testable currently (due to lack of decoupled UI logic).

## 🔧 Maintenance Suggestions
- Refactor input/output into a `UserInterface` class to allow testing.
- Add CSV/JSON export and CLI args support for batch logging.
- Consider GUI version (WinForms/WPF) or web front-end in future iterations.
