using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using MoodLogger.Data;
using MoodLogger.Models;

public class LogManagerTests
{
    private const string TestFilePath = "test-logs.json";

    private void CleanTestFile()
    {
        if (File.Exists(TestFilePath))
            File.Delete(TestFilePath);
    }

    [Fact]
    public void AddLog_ShouldAddLogToList()
    {
        // Arrange
        CleanTestFile();
        var manager = new LogManager(TestFilePath);
        var log = new WellnessLog
        {
            Mood = "Happy",
            SleepHours = "8",
            Activities = "Walk",
            Food = "Salad",
            Weather = "Sunny"
        };

        // Act
        manager.AddLog(log);
        var allLogs = manager.GetAllLogs();

        // Assert
        Assert.Single(allLogs);
        Assert.Equal("Happy", allLogs[0].Mood);

        CleanTestFile();
    }

    [Fact]
    public void GetAllLogs_ShouldReturnListOfLogs()
    {
        // Arrange
        CleanTestFile();
        var sampleData = """
        [
            {
                "Mood": "Calm",
                "SleepHours": "7",
                "Activities": "Yoga",
                "Food": "Soup",
                "Weather": "Cloudy"
            }
        ]
        """;

        File.WriteAllText(TestFilePath, sampleData);
        var manager = new LogManager(TestFilePath);

        // Act
        var logs = manager.GetAllLogs();

        // Assert
        Assert.Single(logs);
        Assert.Equal("Calm", logs[0].Mood);

        CleanTestFile();
    }
}
