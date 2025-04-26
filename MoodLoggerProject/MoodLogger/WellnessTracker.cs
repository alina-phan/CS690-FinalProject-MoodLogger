using MoodLogger.Models;
using MoodLogger.Data;

namespace MoodLogger.Services
{
    public class WellnessTracker
    {
        private readonly LogManager _logManager;

        public WellnessTracker(LogManager logManager)
        {
            _logManager = logManager;
        }

        public void RecordDailyLog()
        {
            var log = new WellnessLog();

            Console.Write("\nHow do you feel today? ");
            log.Mood = Console.ReadLine();

            Console.Write("How many hours did you sleep last night? ");
            log.SleepHours = Console.ReadLine();

            Console.Write("Any notable activities today? ");
            log.Activities = Console.ReadLine();

            Console.Write("What did you eat today? ");
            log.Food = Console.ReadLine();

            Console.Write("What was the weather like? ");
            log.Weather = Console.ReadLine();

            _logManager.AddLog(log);

            Console.WriteLine("\n✅ Your wellness log has been recorded!\n");
        }

        public void ShowAllLogs()
        {
            var logs = _logManager.GetAllLogs();

            if (logs.Count == 0)
            {
                Console.WriteLine("\n📭 No logs found. Start tracking today!\n");
                return;
            }

            Console.WriteLine("\n📊 Wellness Logs Overview:\n");

            foreach (var log in logs)
            {
                Console.WriteLine($"📅 {log.Date}");
                Console.WriteLine($"😌 Mood: {log.Mood}");
                Console.WriteLine($"🛌 Sleep: {log.SleepHours} hours");
                Console.WriteLine($"🏃 Activities: {log.Activities}");
                Console.WriteLine($"🍽️ Food: {log.Food}");
                Console.WriteLine($"⛅ Weather: {log.Weather}");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
