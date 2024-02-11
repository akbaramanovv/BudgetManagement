using BudgetManagement.Application.Models.AnnualBudget;
using BudgetManagement.DataAccess.Repositories;
using BudgetManagement.Shared.Constants;
using FluentValidation;
using System.Threading.Tasks;

namespace BudgetManagement.Application.Models.Validators.AnnualBudget
{
    public class CreateAnnualBudgetValidator : AbstractValidator<CreateAnnualBudgetModel>
    {
        private readonly IAnnualBudgetRepository _annualBudgetRepository;
        public CreateAnnualBudgetValidator(IAnnualBudgetRepository annualBudgetRepository)
        {
            _annualBudgetRepository = annualBudgetRepository;

            RuleFor(cab => cab.Amount)
           .GreaterThan(0)
           .WithMessage(Message.BudgetAmountMustGreatherThanZero);

            RuleFor(cab => cab.Year)
           .GreaterThan(0)
           .WithMessage(Message.YearFormatError)
           .MustAsync((cab, cancellation) => BudgetAlreadyExsist(cab))
           .WithMessage(Message.BudgetAlreadyExsist);
        }

        private async Task<bool> BudgetAlreadyExsist(int year)
        {
            return !(await _annualBudgetRepository.AnyAsync(ab => ab.Year == year));
        }
    }
}
