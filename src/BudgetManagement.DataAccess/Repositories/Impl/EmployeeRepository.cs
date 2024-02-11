using BudgetManagement.Core.Entities;
using BudgetManagement.DataAccess.Persistence;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
namespace BudgetManagement.DataAccess.Repositories.Impl
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public EmployeeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetSection("Database").GetSection("ConnectionString").Value;
        }

        public async Task<bool> EmployeeisExsist(int employeeId)
        {
            return true;
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return new Employee();
        }
    }
}
