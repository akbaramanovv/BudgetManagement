using BudgetManagement.Application.Models;
using BudgetManagement.Application.Models.EmployeeOutgoing;
using BudgetManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BudgetManagement.Application.Services
{
    public interface IEmployeeOutgoingService
    {
        Task<CreateEmployeeOutgoingResponseModel> CreateAsync(CreateEmployeeOutgoingModel createModel);
        Task<List<CreateEmployeeOutgoingResponseModel>> BulkCreateAsync(List<CreateEmployeeOutgoingModel> createModels);
        Task<BaseResponseModel> DeleteAsync(Guid id);
        Task<IEnumerable<EmployeeOutgoingResponseModel>> GetAllAsync(Expression<Func<EmployeeOutgoing, bool>> predicate);
        Task<UpdateEmployeeOutgoingResponseModel> UpdateAsync(Guid id, UpdateEmployeeOutgoingModel updateModel);
    }
}
