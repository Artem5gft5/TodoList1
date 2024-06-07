using System.Linq;
using TodoList.Data;
using TodoList.Models;

namespace TodoList.Extensions
{
    public static class UserExtensions
    {
        public static IQueryable<TodoList.Models.Task> Tasks(this User currentUser, ApplicationDbContext context)
        {
            return context.Tasks.Where(t => t.CreatedBy.Equals(currentUser.UserID));
        }

    }
}
