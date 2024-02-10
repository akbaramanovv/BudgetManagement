using AutoMapper;
using BudgetManagement.Application.Models.TodoItem;
using BudgetManagement.Core.Entities;

namespace BudgetManagement.Application.MappingProfiles
{
    public class TodoItemProfile : Profile
    {
        public TodoItemProfile()
        {
            CreateMap<CreateTodoItemModel, TodoItem>()
                .ForMember(ti => ti.IsDone, ti => ti.MapFrom(cti => false));

            CreateMap<UpdateTodoItemModel, TodoItem>();

            CreateMap<TodoItem, TodoItemResponseModel>();
        }
    }
}
