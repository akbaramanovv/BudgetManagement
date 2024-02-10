using BudgetManagement.Core.Entities;
using BudgetManagement.DataAccess.Persistence;

namespace BudgetManagement.DataAccess.Repositories.Impl
{
    public class TodoItemRepository : BaseRepository<TodoItem>, ITodoItemRepository
    {
        public TodoItemRepository(DatabaseContext context) : base(context)
        { }
    }
}
