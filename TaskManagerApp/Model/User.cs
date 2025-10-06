namespace TaskManagerApp.Model
{
    public class User
    {
        public int Id { get; set; }                       // PK (identity)
        public string Name { get; set; } = string.Empty; // required in OnModelCreating
        public string Email { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;

        // Navigation property: one User can have many Tasks (Assigned tasks)
        public ICollection<TaskItem>? Tasks { get; set; }

    }
}
