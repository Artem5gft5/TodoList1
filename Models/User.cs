namespace TodoList.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public bool IsAdmin { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
