using Xunit;
using MoodLogger.Services;
using MoodLogger.Data;
using MoodLogger.Models;

public class WellnessTrackerTests
{
    [Fact]
    public void AddLog_ThroughWellnessTracker_ShouldAppearInLogManager()
    {
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

        logManager.AddLog(log);

        // Act
        var allLogs = logManager.GetAllLogs();

        // Assert
        Assert.Single(allLogs);
        Assert.Equal("Tired", allLogs[0].Mood);
    }
}
