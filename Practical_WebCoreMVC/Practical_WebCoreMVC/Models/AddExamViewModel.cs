namespace Practical_WebCoreMVC.Models
{
    public class AddExamViewModel
    {
        public string Subject { get; set; }
        public string StartTime { get; set; }
        public DateTime ExamDate { get; set; }
        public int ExamDuration { get; set; }
        public string Classroom { get; set; }
        public string Faculty { get; set; }
        public string? Status { get; set; }


        public AddExamViewModel()
        {
            this.Status = "waiting";
        }
    }
}
