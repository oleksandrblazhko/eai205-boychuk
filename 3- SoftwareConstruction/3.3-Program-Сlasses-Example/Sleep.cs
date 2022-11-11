namespace Sleep_Safety_Reading.Models
{
    public class Sleep
    {
        public int sleepId { get; set; }
        public int minutes { get; set; }
        public TimeOnly sleepStart { get; set; }
        public TimeOnly sleepFinish { get; set; }
        public DateOnly date { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
    }
}
