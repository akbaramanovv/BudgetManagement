﻿namespace BudgetManagement.Application.Models.AnnualBudget
{
    public class CreateAnnualBudgetModel
    {
        public int Year { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
    public class CreateAnnualBudgetModelResponseModel : BaseResponseModel
    { }
}
