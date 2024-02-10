using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetManagement.Application.Services
{
    public interface ITemplateService
    {
        Task<string> GetTemplateAsync(string templateName);

        string ReplaceInTemplate(string input, IDictionary<string, string> replaceWords);
    }
}
