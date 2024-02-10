using AutoMapper;
using BudgetManagement.Application.Models.TodoList;
using BudgetManagement.Core.Entities;

namespace BudgetManagement.Application.MappingProfiles
{
    public class TodoListProfile : Profile
    {
        public TodoListProfile()
        {
            CreateMap<CreateTodoListModel, TodoList>();

            CreateMap<TodoList, TodoListResponseModel>();
        }
    }
}
