using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BudgetManagement.Application.Models;
using BudgetManagement.Application.Models.TodoItem;
using BudgetManagement.Application.Models.TodoList;
using BudgetManagement.Application.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetManagement.API.Controllers
{
    [Authorize]
    public class TodoListsController : ApiController
    {
        private readonly ITodoListService _todoListService;
        private readonly ITodoItemService _todoItemService;

        public TodoListsController(ITodoListService todoListService, ITodoItemService todoItemService)
        {
            _todoListService = todoListService;
            _todoItemService = todoItemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(ApiResult<IEnumerable<TodoListResponseModel>>.Success(await _todoListService.GetAllAsync()));
        }

        [HttpGet("{id:guid}/todoItems")]
        public async Task<IActionResult> GetAllTodoItemsAsync(Guid id)
        {
            return Ok(ApiResult<IEnumerable<TodoItemResponseModel>>.Success(await _todoItemService.GetAllByListIdAsync(id)));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateTodoListModel createTodoListModel)
        {
            return Ok(ApiResult<CreateTodoListResponseModel>.Success(await _todoListService.CreateAsync(createTodoListModel)));
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateAsync(Guid id, UpdateTodoListModel updateTodoListModel)
        {
            return Ok(ApiResult<UpdateTodoListResponseModel>.Success(await _todoListService.UpdateAsync(id, updateTodoListModel)));
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            return Ok(ApiResult<BaseResponseModel>.Success(await _todoListService.DeleteAsync(id)));
        }
    }
}
