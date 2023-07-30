using FluentValidation;
using Sipay_Cohorts_HW5.Api.Applications.GenreOperations.Commands;

namespace Sipay_Cohorts_HW5.Api.Validator.Genre
{
    public class CreateGenreCommandValidator:AbstractValidator<CreateGenreCommand>
    {
        public CreateGenreCommandValidator()
        {
            RuleFor(query => query.Model.Name).NotEmpty().MinimumLength(4);
        }
    }
}
