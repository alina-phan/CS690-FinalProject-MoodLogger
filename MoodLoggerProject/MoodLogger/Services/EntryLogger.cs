using MoodLogger.Models;
using MoodLogger.Data;

namespace MoodLogger.Services
{
    public class EntryLogger
    {
        private readonly DataStore _dataStore;

        public EntryLogger(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public void LogEntry()
        {
            var entry = new Entry();

            Console.Write("Enter today's mood: ");
            entry.Mood = Console.ReadLine();

            Console.Write("Hours of sleep last night: ");
            entry.SleepHours = Console.ReadLine();

            Console.Write("Activities today: ");
            entry.Activities = Console.ReadLine();

            Console.Write("What did you eat today?: ");
            entry.Food = Console.ReadLine();

            Console.Write("Weather today: ");
            entry.Weather = Console.ReadLine();

            _dataStore.AddEntry(entry);

            Console.WriteLine("\nEntry saved!\n");
        }

        public void ViewEntries()
        {
            var entries = _dataStore.GetAllEntries();

            foreach (var entry in entries)
            {
                Console.WriteLine($"\nDate: {entry.Date}");
                Console.WriteLine($"Mood: {entry.Mood}");
                Console.WriteLine($"Sleep: {entry.SleepHours}");
                Console.WriteLine($"Activities: {entry.Activities}");
                Console.WriteLine($"Food: {entry.Food}");
                Console.WriteLine($"Weather: {entry.Weather}");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
