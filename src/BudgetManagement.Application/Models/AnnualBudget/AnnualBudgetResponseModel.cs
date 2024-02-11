namespace BudgetManagement.Application.Models.AnnualBudget
{
    public class AnnualBudgetResponseModel : BaseResponseModel
    {
        public int Year { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}
