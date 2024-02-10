using BudgetManagement.Application.Models.WeatherForecast;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetManagement.Application.Services
{
    public interface IWeatherForecastService
    {
        public Task<IEnumerable<WeatherForecastResponseModel>> GetAsync();
    }
}
