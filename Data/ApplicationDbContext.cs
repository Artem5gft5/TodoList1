using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<TodoList.Models.Task> Tasks { get; set; }
        public DbSet<TaskCompletion> TaskCompletions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoList.Models.Task>()
                .HasOne(t => t.User)
                .WithMany(u => u.Tasks)
                .HasForeignKey(t => t.CreatedBy);
        }
    }
}



