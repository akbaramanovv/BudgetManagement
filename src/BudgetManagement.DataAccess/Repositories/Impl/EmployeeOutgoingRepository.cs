using BudgetManagement.Core.Entities;
using BudgetManagement.DataAccess.Persistence;

namespace BudgetManagement.DataAccess.Repositories.Impl
{
    public class EmployeeOutgoingRepository : BaseRepository<EmployeeOutgoing>, IEmployeeOutgoingRepository
    {
        public EmployeeOutgoingRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
