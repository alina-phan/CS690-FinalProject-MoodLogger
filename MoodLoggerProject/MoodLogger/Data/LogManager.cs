using MoodLogger.Models;
using System.Text.Json;

namespace MoodLogger.Data
{
    public class LogManager
    {
        private const string FilePath = "logs.json";
        private List<WellnessLog> logs;

        public LogManager()
        {
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
            File.WriteAllText(FilePath, json);
        }

        private List<WellnessLog> LoadLogs()
        {
            if (!File.Exists(FilePath))
                return new List<WellnessLog>();

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<WellnessLog>>(json) ?? new List<WellnessLog>();
        }
    }
}
