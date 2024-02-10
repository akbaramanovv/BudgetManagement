using AutoMapper;
using BudgetManagement.Application.Models.User;
using BudgetManagement.DataAccess.Identity;

namespace BudgetManagement.Application.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserModel, ApplicationUser>();
        }
    }
}
