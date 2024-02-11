using BudgetManagement.Core.Common;
using System;

namespace BudgetManagement.Core.Entities
{
    public class EmployeeOutgoing : BaseEntity, IAuditedEntity
    {
        public int EmployeID { get; set; }
        public decimal SpentAmount { get; set; }
        public DateTime SpentTime { get; set; }
        public string SpentLocation { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
