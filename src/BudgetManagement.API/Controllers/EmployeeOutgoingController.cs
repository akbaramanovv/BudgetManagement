using BudgetManagement.Application.Models;
using BudgetManagement.Application.Models.EmployeeOutgoing;
using BudgetManagement.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeOutgoingController : ApiController
    {
        private readonly IEmployeeOutgoingService _employeeOutgoingService;

        public EmployeeOutgoingController(IEmployeeOutgoingService employeeOutgoingService)
        {
            _employeeOutgoingService = employeeOutgoingService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateEmployeeOutgoingModel createEmployeeOutgoingModel)
        {
            return Ok(ApiResult<CreateEmployeeOutgoingResponseModel>.Success(await _employeeOutgoingService.CreateAsync(createEmployeeOutgoingModel)));
        }

        [HttpPost]
        [Route("BulkInsert")]
        public async Task<IActionResult> BulkCreateAsync(List<CreateEmployeeOutgoingModel> createEmployeeOutgoingModel)
        {
            return Ok(ApiResult<List<CreateEmployeeOutgoingResponseModel>>.Success(await _employeeOutgoingService.BulkCreateAsync(createEmployeeOutgoingModel)));
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateAsync(Guid id, UpdateEmployeeOutgoingModel updateEmployeeOutgoingModel)
        {
            return Ok(ApiResult<UpdateEmployeeOutgoingResponseModel>.Success(await _employeeOutgoingService.UpdateAsync(id, updateEmployeeOutgoingModel)));
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            return Ok(ApiResult<BaseResponseModel>.Success(await _employeeOutgoingService.DeleteAsync(id)));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(int employeeId)
        {
            return Ok(ApiResult<IEnumerable<EmployeeOutgoingResponseModel>>.Success(await _employeeOutgoingService.GetAllAsync(eo=>eo.EmployeID == employeeId)));
        }
    }
}
