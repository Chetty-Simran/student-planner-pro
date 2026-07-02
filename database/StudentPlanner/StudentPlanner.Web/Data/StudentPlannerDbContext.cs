using Microsoft.EntityFrameworkCore;
using StudentPlanner.Web.Models;

namespace StudentPlanner.Web.Data
{
    public class StudentPlannerDbContext : DbContext
    {
        public StudentPlannerDbContext(DbContextOptions<StudentPlannerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment> Assignments { get; set; }
    }
}