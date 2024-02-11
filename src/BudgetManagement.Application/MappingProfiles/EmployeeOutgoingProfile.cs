using AutoMapper;
using BudgetManagement.Application.Models.AnnualBudget;
using BudgetManagement.Application.Models.EmployeeOutgoing;
using BudgetManagement.Core.Entities;

namespace BudgetManagement.Application.MappingProfiles
{
    public class EmployeeOutgoingProfile : Profile
    {
        public EmployeeOutgoingProfile()
        {
            CreateMap<UpdateEmployeeOutgoingModel, EmployeeOutgoing>();

            CreateMap<CreateEmployeeOutgoingModel, EmployeeOutgoing>();

            CreateMap<EmployeeOutgoing, EmployeeOutgoingResponseModel>();
        }
    }
}
