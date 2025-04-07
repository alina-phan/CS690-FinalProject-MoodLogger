using Xunit;
using MoodLogger.Data;
using MoodLogger.Models;
using System.Collections.Generic;

public class LogManagerTests
{
    [Fact]
    public void AddLog_ShouldAddLogToList()
    {
        // Arrange
        var logManager = new LogManager();
        var log = new WellnessLog { Mood = "Happy", SleepHours = "7" };

        // Act
        logManager.AddLog(log);
        var logs = logManager.GetAllLogs();

        // Assert
        Assert.Contains(logs, l => l.Mood == "Happy" && l.SleepHours == "7");
    }

    [Fact]
    public void GetAllLogs_ShouldReturnListOfLogs()
    {
        // Arrange
        var logManager = new LogManager();
        var initialLogs = logManager.GetAllLogs();

        // Act & Assert
        Assert.NotNull(initialLogs);
        Assert.IsType<List<WellnessLog>>(initialLogs);
    }
}
