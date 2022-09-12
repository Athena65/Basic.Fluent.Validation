using ExternalModels.Models;
using FluentValidation;

namespace AddingFluent_Validation_toWeb_Api.Validators
{
    public class TesterValidator:AbstractValidator<Tester>
    {
        public TesterValidator()
        {
            RuleFor(p => p.FirstName)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("{PropertyName} should be not empty")
               .Length(2, 25);
            RuleFor(p => p.Email)
               .EmailAddress();
        }
    }
}
