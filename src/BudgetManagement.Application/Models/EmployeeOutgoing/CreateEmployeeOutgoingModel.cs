using System;

namespace BudgetManagement.Application.Models.EmployeeOutgoing
{
    public class CreateEmployeeOutgoingModel
    {
        public int EmployeID { get; set; }
        public decimal SpentAmount { get; set; }
        public DateTime SpentTime { get; set; }
        public string SpentLocation { get; set; }
    }
    public class CreateEmployeeOutgoingResponseModel : BaseResponseModel
    { }
}
