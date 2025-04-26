namespace MoodLogger.Models
{
    public class WellnessLog
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string Mood { get; set; }
        public string SleepHours { get; set; }
        public string Activities { get; set; }
        public string Food { get; set; }
        public string Weather { get; set; }
    }
}
