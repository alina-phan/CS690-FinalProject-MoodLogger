using MoodLogger.Services;
using MoodLogger.Data;

namespace MoodLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataStore = new DataStore();
            var logger = new EntryLogger(dataStore);

            while (true)
            {
                Console.WriteLine("=== Emma's Mood Logger ===");
                Console.WriteLine("1. Log new entry");
                Console.WriteLine("2. View all entries");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        logger.LogEntry();
                        break;
                    case "2":
                        logger.ViewEntries();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid option.\n");
                        break;
                }
            }
        }
    }
}
