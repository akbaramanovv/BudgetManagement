﻿using BudgetManagement.Application.Models;
using BudgetManagement.Application.Models.TodoItem;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetManagement.Application.Services
{
    public interface ITodoItemService
    {
        Task<CreateTodoItemResponseModel> CreateAsync(CreateTodoItemModel createTodoItemModel);

        Task<BaseResponseModel> DeleteAsync(Guid id);

        Task<IEnumerable<TodoItemResponseModel>> GetAllByListIdAsync(Guid id);

        Task<UpdateTodoItemResponseModel> UpdateAsync(Guid id, UpdateTodoItemModel updateTodoItemModel);
    }
}
