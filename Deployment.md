# 🚀 Deployment Instructions – Emma's Wellness Tracker

This document explains how to run the CS690 Final Project – **MoodLogger** – as a standalone, self-contained application on Windows. No additional setup or installation is required.

---

## 📦 Download the Release Build

👉 [Click here to download the latest release (v1.0.0)](https://github.com/alina-phan/CS690-FinalProject-MoodLogger/releases/latest)

---

## 💻 System Requirements

- Windows 10 or 11 (64-bit)
- No .NET SDK or runtime installation required
- ~30 MB free space to extract the files

---

## 🧰 Installation Steps

1. Download the ZIP file from the [GitHub Releases page](https://github.com/alina-phan/CS690-FinalProject-MoodLogger/releases/latest)
2. Extract the contents to any folder on your system
3. Open the folder and double-click:

```bash
MoodLogger.exe
The app will launch in your terminal and begin logging based on your input.

🔍 What This App Does

Emma's Wellness Tracker helps users like Emma log and reflect on:

- Mood

- Sleep

- Food

- Physical activity

- Weather conditions

All entries are saved locally to logs.json

📝 Troubleshooting

- Nothing happens when I click the .exe: Try right-clicking → “Run as Administrator”

- Blocked by Windows Defender?: Click “More Info” → “Run Anyway” (this happens for unsigned apps)

🧪 Want to Build It Yourself?

If you'd rather build from source:

```
git clone https://github.com/alina-phan/CS690-FinalProject-MoodLogger.git
cd CS690-FinalProject-MoodLogger/MoodLoggerProject/MoodLogger
dotnet run
```
For any issues, please reach out via the Issues tab.
