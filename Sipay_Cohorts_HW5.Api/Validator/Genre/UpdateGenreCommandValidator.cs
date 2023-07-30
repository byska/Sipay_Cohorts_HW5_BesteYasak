using FluentValidation;
using Sipay_Cohorts_HW5.Api.Applications.AuthorOperations.Commands;

namespace Sipay_Cohorts_HW5.Api.Validator.Genre
{
    public class UpdateGenreCommandValidator:AbstractValidator<UpdateGenreCommand>
    {
        public UpdateGenreCommandValidator()
        {
            RuleFor(x=>x.Model.Name).MinimumLength(4).When(x=>x.Model.Name.Trim() != string.Empty);
            RuleFor(x=>x.GenreId).GreaterThan(0);
          
        }
    }
}
