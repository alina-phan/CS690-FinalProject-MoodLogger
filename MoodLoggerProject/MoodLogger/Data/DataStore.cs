using MoodLogger.Models;

namespace MoodLogger.Data
{
    public class DataStore
    {
        private List<Entry> entries = new();

        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public List<Entry> GetAllEntries()
        {
            return entries;
        }
    }
}
