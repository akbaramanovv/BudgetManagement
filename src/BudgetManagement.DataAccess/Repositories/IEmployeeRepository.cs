using BudgetManagement.Core.Entities;
using System.Threading.Tasks;

namespace BudgetManagement.DataAccess.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployeeById(int employeeId);
        Task<bool> EmployeeisExsist(int employeeId);
    }
}
