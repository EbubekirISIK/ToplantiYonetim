namespace MeetingApp.Models
{
    public class MeetingInfo
    {
        public int id { get; set; }
        public string? Location { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfPeople { get; set; }
    }
}
