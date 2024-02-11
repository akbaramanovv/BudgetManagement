using AutoMapper;
using BudgetManagement.Application.Exceptions;
using BudgetManagement.Application.Models;
using BudgetManagement.Application.Models.AnnualBudget;
using BudgetManagement.Core.Entities;
using BudgetManagement.DataAccess.Repositories;
using BudgetManagement.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BudgetManagement.Application.Services.Impl
{
    public class AnnualBudgetService : IAnnualBudgetService
    {
        private readonly IAnnualBudgetRepository _annualBudgetRepository;
        private readonly IMapper _mapper;

        public AnnualBudgetService(IAnnualBudgetRepository annualBudgetRepository,
                                   IMapper mapper)
        {
            _annualBudgetRepository = annualBudgetRepository;
            _mapper = mapper;
        }
        public async Task<CreateAnnualBudgetModelResponseModel> CreateAsync(CreateAnnualBudgetModel createAnnualBudgetModel)
        {
            var annualBudget = _mapper.Map<AnnualBudget>(createAnnualBudgetModel);

            var addedAnnualBudget = await _annualBudgetRepository.AddAsync(annualBudget);

            return new CreateAnnualBudgetModelResponseModel
            {
                Id = addedAnnualBudget.Id
            };
        }

        public async Task<BaseResponseModel> DeleteAsync(Guid id)
        {
            var annualBudget = await _annualBudgetRepository.GetFirstAsync(ab => ab.Id == id);

            return new BaseResponseModel
            {
                Id = (await _annualBudgetRepository.DeleteAsync(annualBudget)).Id
            };
        }

        public async Task<IEnumerable<AnnualBudgetResponseModel>> GetAll()
        {
            var annualBudgets = await _annualBudgetRepository.GetAllAsync(null);

            return _mapper.Map<IEnumerable<AnnualBudgetResponseModel>>(annualBudgets);
        }

        public async Task<AnnualBudgetResponseModel> GetById(Guid id)
        {
            var annualBudget = await _annualBudgetRepository.GetFirstAsync(ab => ab.Id == id);

            return _mapper.Map<AnnualBudgetResponseModel>(annualBudget);
        }

        public async Task<AnnualBudgetResponseModel> GetByYear(int year)
        {
            var annualBudget = await _annualBudgetRepository.GetFirstAsync(ab => ab.Year == year);

            return _mapper.Map<AnnualBudgetResponseModel>(annualBudget);
        }

        public async Task<UpdateAnnualBudgetResponseModel> UpdateAsync(Guid id, UpdateAnnualBudgetModel updateAnnualBudgetModel)
        {
            var annualBudget = await _annualBudgetRepository.GetFirstAsync(ab => ab.Id == id);

            _mapper.Map(updateAnnualBudgetModel, annualBudget);

            return new UpdateAnnualBudgetResponseModel
            {
                Id = (await _annualBudgetRepository.UpdateAsync(annualBudget)).Id
            };
        }
    }
}
