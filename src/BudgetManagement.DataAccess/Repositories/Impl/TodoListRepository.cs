using BudgetManagement.Core.Entities;
using BudgetManagement.DataAccess.Persistence;

namespace BudgetManagement.DataAccess.Repositories.Impl
{
    public class TodoListRepository : BaseRepository<TodoList>, ITodoListRepository
    {
        public TodoListRepository(DatabaseContext context) : base(context)
        { }
    }
}
