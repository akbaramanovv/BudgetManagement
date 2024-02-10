using BudgetManagement.Application.Common.Email;
using System.Threading.Tasks;

namespace BudgetManagement.Application.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(EmailMessage emailMessage);
    }
}
