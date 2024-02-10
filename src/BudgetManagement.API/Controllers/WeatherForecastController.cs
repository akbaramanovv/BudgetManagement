using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BudgetManagement.Application.Models;
using BudgetManagement.Application.Models.WeatherForecast;
using BudgetManagement.Application.Services;

namespace BudgetManagement.API.Controllers
{
    [Authorize]
    public class WeatherForecastController : ApiController
    {
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(ApiResult<IEnumerable<WeatherForecastResponseModel>>.Success(await _weatherForecastService.GetAsync()));
    }
}
