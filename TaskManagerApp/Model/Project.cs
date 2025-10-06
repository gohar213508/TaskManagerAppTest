namespace TaskManagerApp.Model
{
    public class Project
    {
        public int Id { get; set; }                        // PK
        public string Name { get; set; } = string.Empty;  // required
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Navigation property: one Project has many Tasks
        public ICollection<TaskItem>? Tasks { get; set; }
    }
}

