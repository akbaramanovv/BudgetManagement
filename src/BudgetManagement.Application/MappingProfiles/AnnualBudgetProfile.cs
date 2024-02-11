using AutoMapper;
using BudgetManagement.Application.Models.AnnualBudget;
using BudgetManagement.Core.Entities;

namespace BudgetManagement.Application.MappingProfiles
{
    public class AnnualBudgetProfile : Profile
    {
        public AnnualBudgetProfile()
        {
            CreateMap<UpdateAnnualBudgetModel, AnnualBudget>();

            CreateMap<CreateAnnualBudgetModel, AnnualBudget>();

            CreateMap<AnnualBudget, AnnualBudgetResponseModel>();
        }
    }
}
