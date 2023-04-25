namespace Boss_az_Task.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public Vacancy Vacancy { get; set; }
        public int VacancyId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public DateTime ShareDate { get; set; }
    }
}
