using MoodLogger.Models;
using System.Text.Json;

namespace MoodLogger.Data
{
    public class LogManager
    {
        private readonly string _filePath;
        private List<WellnessLog> logs;

        // Constructor with optional file path (used for testing)
        public LogManager(string filePath = "logs.json")
        {
            _filePath = filePath;
            logs = LoadLogs();
        }

        public void AddLog(WellnessLog log)
        {
            logs.Add(log);
            SaveLogs(); // Persist immediately
        }

        public List<WellnessLog> GetAllLogs()
        {
            return logs;
        }

        private void SaveLogs()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(logs, options);
            File.WriteAllText(_filePath, json);
        }

        private List<WellnessLog> LoadLogs()
        {
            if (!File.Exists(_filePath))
                return new List<WellnessLog>();

            try
            {
                string json = File.ReadAllText(_filePath);
                return JsonSerializer.Deserialize<List<WellnessLog>>(json) ?? new List<WellnessLog>();
            }
            catch (JsonException)
            {
                // Return an empty list if JSON is malformed
                return new List<WellnessLog>();
            }
        }
    }
}
