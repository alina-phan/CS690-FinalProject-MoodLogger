using MoodLogger.Services;
using MoodLogger.Data;

namespace MoodLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var logManager = new LogManager();
            var tracker = new WellnessTracker(logManager);

            while (true)
            {
                Console.WriteLine("\n🌿 Welcome to Emma's Wellness Tracker 🌿");
                Console.WriteLine("1. Record a new log");
                Console.WriteLine("2. View all past logs");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option (1-3): ");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        tracker.RecordDailyLog();
                        break;
                    case "2":
                        tracker.ShowAllLogs();
                        break;
                    case "3":
                        Console.WriteLine("Goodbye! Stay well. 🌟");
                        return;
                    default:
                        Console.WriteLine("❗ Invalid option. Please choose 1, 2, or 3.\n");
                        break;
                }
            }
        }
    }
}
