using Xunit;
using MoodLogger.Services;
using MoodLogger.Data;
using MoodLogger.Models;
using System.IO;

public class WellnessTrackerTests
{
    [Fact]
    public void AddLog_ThroughWellnessTracker_ShouldAppearInLogManager()
    {
        // Clear the log file to ensure test isolation
        File.WriteAllText("logs.json", "[]");

        // Arrange
        var logManager = new LogManager();
        var tracker = new WellnessTracker(logManager);

        var log = new WellnessLog
        {
            Mood = "Tired",
            SleepHours = "5",
            Activities = "Work",
            Food = "Salad",
            Weather = "Cloudy"
        };

        // Act
        logManager.AddLog(log);
        var allLogs = logManager.GetAllLogs();

        // Assert
        Assert.Single(allLogs);
        Assert.Equal("Tired", allLogs[0].Mood);
    }
}
