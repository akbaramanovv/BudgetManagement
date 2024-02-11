using BudgetManagement.Core.Common;
using System;

namespace BudgetManagement.Core.Entities
{
    public class AnnualBudget : BaseEntity, IAuditedEntity
    {
        public int Year { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
