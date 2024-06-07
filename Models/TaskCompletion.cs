using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class TaskCompletion
    {
        [Key]
        public int CompletionID { get; set; }

        [ForeignKey("Task")]
        public int TaskID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        public bool IsCompleted { get; set; } = true;

        public DateTime CompletedAt { get; set; } = DateTime.Now;

        public virtual Task Task { get; set; }
        public virtual User User { get; set; }
    }
}
