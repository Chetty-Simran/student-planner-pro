using StudentPlanner.Web.Enums;

namespace StudentPlanner.Web.Models
{
    public class Assignment
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public required string Module { get; set; }

        public string? Description { get; set; }

        public DateTime DueDate { get; set; }

        public Priority Priority { get; set; }

        public AssignmentStatus Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool IsCompleted { get; set; }
    }
}