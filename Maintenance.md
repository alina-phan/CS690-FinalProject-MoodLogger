# 🧰 Maintenance Plan for Emma's Wellness Tracker

## 🔍 Overview
This maintenance plan outlines the known limitations, improvement opportunities, and strategies to ensure the system remains functional and extensible in the future.

---

## 🧱 Current State

- ✅ Core functionality: Logging mood, sleep, food, activity, and weather.
- ✅ Data saved to and loaded from `logs.json`.
- ✅ Unit tests included for key components (`LogManager`, `WellnessTracker`).
- ✅ Automated test workflow via GitHub Actions.

---

## 🐞 Known Issues / Gaps

- ❌ Weather influence is user-entered — no integration with a weather API.
- ❌ No reporting/trend visualization (CSV export or mood summaries).
- ❌ Minimal input validation — currently assumes valid user input.
- ❌ Not yet built for multiple users or sessions.
- ❌ UI is console-based — not ideal for broader adoption.

---

## 🔧 Suggested Fixes & Enhancements

| Area              | Suggestion                                                                 |
|-------------------|----------------------------------------------------------------------------|
| Testing           | Improve test isolation by mocking file system or using in-memory storage. |
| UI/UX             | Migrate to WinForms or web interface for better interaction.               |
| Weather Data      | Integrate with a weather API (e.g., OpenWeather) for automated input.      |
| Data Export       | Add CSV export for daily logs or summaries.                               |
| Multi-user support| Add usernames or profiles to isolate logs per user.                        |

---

## 🔁 Maintenance Best Practices

- Keep `logs.json` under version control *only* if using test data.
- Backup logs before major updates.
- Use semantic versioning for future releases (`v1.0.1`, `v1.1.0`, etc.).
- Expand unit tests when new features are added.
- Keep GitHub Actions workflow up to date with new test coverage.

---

## 💡 Future Ideas

- 📊 Mood graph or calendar-based visualization
- 🌐 Mobile/web version using Blazor or MAUI
- ☁️ Cloud sync using Firebase or Supabase
