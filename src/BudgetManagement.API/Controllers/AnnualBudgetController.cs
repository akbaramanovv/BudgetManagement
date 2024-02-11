using BudgetManagement.Application.Models;
using BudgetManagement.Application.Models.AnnualBudget;
using BudgetManagement.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnualBudgetController : ApiController
    {
        private readonly IAnnualBudgetService _annualBudgetService;

        public AnnualBudgetController(IAnnualBudgetService annualBudgetService)
        {
            _annualBudgetService = annualBudgetService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateAnnualBudgetModel createAnnualBudgetModel)
        {
            return Ok(ApiResult<CreateAnnualBudgetModelResponseModel>.Success(await _annualBudgetService.CreateAsync(createAnnualBudgetModel)));
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateAsync(Guid id, UpdateAnnualBudgetModel updateAnnualBudgetModel)
        {
            return Ok(ApiResult<UpdateAnnualBudgetResponseModel>.Success(await _annualBudgetService.UpdateAsync(id, updateAnnualBudgetModel)));
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            return Ok(ApiResult<BaseResponseModel>.Success(await _annualBudgetService.DeleteAsync(id)));
        }

        [HttpGet]
        [Route("GetByYear")]
        public async Task<IActionResult> GetByYear(int year)
        {
            return Ok(ApiResult<AnnualBudgetResponseModel>.Success(await _annualBudgetService.GetByYear(year)));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(ApiResult<IEnumerable<AnnualBudgetResponseModel>>.Success(await _annualBudgetService.GetAll()));
        }
    }
}
