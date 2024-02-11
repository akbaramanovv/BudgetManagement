using System;

namespace BudgetManagement.Application.Models.AnnualBudget
{
    public class UpdateAnnualBudgetModel
    {
        public Guid Id { get; set; }
        public int Year { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }

    public class UpdateAnnualBudgetResponseModel : BaseResponseModel
    { }
}
