using BudgetManagement.Application.Models.AnnualBudget;
using BudgetManagement.DataAccess.Repositories;
using BudgetManagement.Shared.Constants;
using FluentValidation;
using System.Threading.Tasks;

namespace BudgetManagement.Application.Models.Validators.AnnualBudget
{
    public class UpdateAnnualBudgetValidator : AbstractValidator<UpdateAnnualBudgetModel>
    {
        private readonly IAnnualBudgetRepository _annualBudgetRepository;
        public UpdateAnnualBudgetValidator(IAnnualBudgetRepository annualBudgetRepository)
        {
            _annualBudgetRepository = annualBudgetRepository;

            RuleFor(cab => cab.Amount)
           .GreaterThan(0)
           .WithMessage(Message.BudgetAmountMustGreatherThanZero);

           RuleFor(cab => cab.Year)
          .GreaterThan(0)
          .WithMessage(Message.YearFormatError);

            RuleFor(cab => cab)
           .MustAsync((cab, cancellation) => BudgetExsist(cab))
           .WithMessage(Message.BudgetAmountIsNotExsist);
        }

        private async Task<bool> BudgetExsist(UpdateAnnualBudgetModel annualBudgetModel)
        {
            return (await _annualBudgetRepository.AnyAsync(ab => ab.Id == annualBudgetModel.Id));
        }
    }
}
