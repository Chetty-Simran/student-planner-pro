namespace StudentPlanner.Web.Models
{
    public class Assignment
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Module { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }
    }
}