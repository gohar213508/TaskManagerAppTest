namespace TaskManagerApp.Model
{
    public class TaskItem
    {
        public int Id { get; set; }                        // PK
        public string Title { get; set; } = string.Empty; // required
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";   // Pending/InProgress/Completed
        public string Priority { get; set; } = "Medium";  // Low/Medium/High
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Foreign key to User (who is assigned). Nullable so a task can be unassigned.
        public int? AssignedToUserId { get; set; }
        public User? AssignedTo { get; set; } // navigation

        // Foreign key to Project (task must belong to a project)
        public int ProjectId { get; set; }
        public Project? Project { get; set; } // navigation
    }
}
