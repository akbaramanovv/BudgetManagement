using BudgetManagement.Core.Entities;
using BudgetManagement.DataAccess.Persistence;

namespace BudgetManagement.DataAccess.Repositories.Impl
{
    public class AnnualBudgetRepository : BaseRepository<AnnualBudget>, IAnnualBudgetRepository
    {
        public AnnualBudgetRepository(DatabaseContext context) : base(context)
        { }
    }
}
