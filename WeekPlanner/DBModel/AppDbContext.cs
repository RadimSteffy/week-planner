using System.Data.Entity;

namespace WeekPlanner.DBModel
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("WeekPlannerDB")
        {
            
        }

        public DbSet<DayAndTime> DayAndTimes { get; set; }
    }
}