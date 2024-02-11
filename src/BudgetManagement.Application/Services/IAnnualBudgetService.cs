using BudgetManagement.Application.Models;
using BudgetManagement.Application.Models.AnnualBudget;
using BudgetManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BudgetManagement.Application.Services
{
    public interface IAnnualBudgetService
    {
        Task<CreateAnnualBudgetModelResponseModel> CreateAsync(CreateAnnualBudgetModel createTodoItemModel);
        Task<BaseResponseModel> DeleteAsync(Guid id);
        Task<IEnumerable<AnnualBudgetResponseModel>> GetAll();
        Task<AnnualBudgetResponseModel> GetById(Guid id);
        Task<AnnualBudgetResponseModel> GetByYear(int year);
        Task<UpdateAnnualBudgetResponseModel> UpdateAsync(Guid id, UpdateAnnualBudgetModel updateTodoItemModel);
    }
}
