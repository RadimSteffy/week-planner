using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeekPlanner.DBModel
{

    [Table("DayAndTimes")]
    public class DayAndTime
    {
        [Key()]
        public int ID { get; set; }

        public string Name { get; set; }
        public string TaskName { get; set; }

    }
}