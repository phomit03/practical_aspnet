namespace Practical_WebCoreMVC.Models.Domain
{
    public class Exam
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string StartTime { get; set; }
        public DateTime ExamDate { get; set; }
        public int ExamDuration { get; set; }
        public string Classroom { get; set; }
        public string Faculty { get; set; }
        public string? Status { get; set; }

        public Exam()
        {
            this.Status = "waiting";
        }
    }
}
