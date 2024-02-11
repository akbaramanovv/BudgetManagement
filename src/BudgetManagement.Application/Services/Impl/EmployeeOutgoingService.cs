using AutoMapper;
using BudgetManagement.Application.Models;
using BudgetManagement.Application.Models.EmployeeOutgoing;
using BudgetManagement.Core.Entities;
using BudgetManagement.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BudgetManagement.Application.Services.Impl
{
    public class EmployeeOutgoingService : IEmployeeOutgoingService
    {
        private readonly IEmployeeOutgoingRepository _employeeOutgoingrepository;
        private readonly IMapper _mapper;
        public EmployeeOutgoingService(IEmployeeOutgoingRepository employeeOutgoingrepository,
                                       IMapper mapper)
        {
            _employeeOutgoingrepository = employeeOutgoingrepository;
            _mapper = mapper;
        }

        public async Task<List<CreateEmployeeOutgoingResponseModel>> BulkCreateAsync(List<CreateEmployeeOutgoingModel> createModels)
        {
            var response = new List<CreateEmployeeOutgoingResponseModel>();
            foreach (var model in createModels)
            {
                var employeeOutCome = _mapper.Map<EmployeeOutgoing>(model);
                var addedEmployeeOutCome = await _employeeOutgoingrepository.AddAsync(employeeOutCome);
                response.Add(new CreateEmployeeOutgoingResponseModel { Id = addedEmployeeOutCome.Id });
            }
            return response;
        }

        public async Task<CreateEmployeeOutgoingResponseModel> CreateAsync(CreateEmployeeOutgoingModel createModel)
        {
            var employeeOutCome = _mapper.Map<EmployeeOutgoing>(createModel);
            var addedEmployeeOutCome = await _employeeOutgoingrepository.AddAsync(employeeOutCome);
            return new CreateEmployeeOutgoingResponseModel()
            {
                Id = addedEmployeeOutCome.Id
            };
        }

        public async Task<BaseResponseModel> DeleteAsync(Guid id)
        {
            var employeeOutCome = await _employeeOutgoingrepository.GetFirstAsync(ec => ec.Id == id);

            return new BaseResponseModel
            {
                Id = (await _employeeOutgoingrepository.DeleteAsync(employeeOutCome)).Id
            };
        }

        public async Task<IEnumerable<EmployeeOutgoingResponseModel>> GetAllAsync(Expression<Func<EmployeeOutgoing, bool>> predicate)
        {
            var employeeOutComes = await _employeeOutgoingrepository.GetAllAsync(predicate);
            return _mapper.Map<IEnumerable<EmployeeOutgoingResponseModel>>(employeeOutComes);
        }

        public async Task<UpdateEmployeeOutgoingResponseModel> UpdateAsync(Guid id, UpdateEmployeeOutgoingModel updateModel)
        {
            var employeeOutCome = await _employeeOutgoingrepository.GetFirstAsync(ec => ec.Id == id);

            _mapper.Map(updateModel, employeeOutCome);

            return new UpdateEmployeeOutgoingResponseModel
            {
                Id = (await _employeeOutgoingrepository.UpdateAsync(employeeOutCome)).Id
            };
        }
    }
}
