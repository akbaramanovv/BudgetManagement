using BudgetManagement.Application.Models;
using BudgetManagement.Application.Models.TodoList;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetManagement.Application.Services
{
    public interface ITodoListService
    {
        Task<CreateTodoListResponseModel> CreateAsync(CreateTodoListModel createTodoListModel);

        Task<BaseResponseModel> DeleteAsync(Guid id);

        Task<IEnumerable<TodoListResponseModel>> GetAllAsync();

        Task<UpdateTodoListResponseModel> UpdateAsync(Guid id, UpdateTodoListModel updateTodoListModel);
    }
}
