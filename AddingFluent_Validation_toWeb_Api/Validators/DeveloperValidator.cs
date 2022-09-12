using AddingFluent_Validation_toWeb_Api.Models;
using FluentValidation;

namespace AddingFluent_Validation_toWeb_Api.Validators
{
    public class DeveloperValidator:AbstractValidator<Developer>
    {
        public DeveloperValidator()
        {
            RuleFor(p=>p.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} should be not empty!")
                .Length(2,25)
                .Must(IsValidName).WithMessage("{PropertyName} should be all letters!");

            RuleFor(p => p.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} should be not empty!")
                .Length(2, 25)
                .Must(IsValidName).WithMessage("{PropertyName} should be all letters!");
            RuleFor(p => p.Email)
                .EmailAddress();
        }
        private bool IsValidName(string name)
        {
            return name.All(Char.IsLetter);
        }
            
    }
}
