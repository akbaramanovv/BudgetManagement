using System;

namespace BudgetManagement.Application.Models.EmployeeOutgoing
{
    public class UpdateEmployeeOutgoingModel
    {
        public Guid Id { get; set; }
        public int EmployeID { get; set; }
        public decimal SpentAmount { get; set; }
        public DateTime SpentTime { get; set; }
        public string SpentLocation { get; set; }
    }
    public class UpdateEmployeeOutgoingResponseModel : BaseResponseModel
    {  }
}
