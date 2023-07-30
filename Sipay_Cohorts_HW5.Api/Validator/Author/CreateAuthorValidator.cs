using FluentValidation;
using Sipay_Cohorts_HW5.Api.Applications.AuthorOperations.Commands;

namespace Sipay_Cohorts_HW5.Api.Validator.Author
{
    public class CreateAuthorValidator:AbstractValidator<AddAuthorCommand>
    {
        public CreateAuthorValidator()
        {
            RuleFor(x=>x.Model.Name).NotEmpty().MinimumLength(3);
            RuleFor(x=>x.Model.LastName).NotEmpty().MinimumLength(3);
            RuleFor(x=>x.Model.BirthDate).NotEmpty().LessThan(DateTime.Now.Date);
        }
    }
}
