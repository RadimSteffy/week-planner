namespace WeekPlanner.ViewModels
{
    public class Task
    {
        public int ID { get; set; }
        public string TaskID { get; set; }
        public string Name { get; set; }
        public virtual Task task { get; set; }
    }
}