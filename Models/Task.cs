using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Models
{
    public class Task
    {
        [Key]
        public int TaskID { get; set; }

        [Required]
        public string TaskName { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ForeignKey("User")]
        public int CreatedBy { get; set; } 

        public virtual User User { get; set; }
    }
}
