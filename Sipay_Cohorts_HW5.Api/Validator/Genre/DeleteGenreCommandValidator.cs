using FluentValidation;
using Sipay_Cohorts_HW5.Api.Applications.BookOperations.Commands;
using Sipay_Cohorts_HW5.Api.Applications.GenreOperations.Commands;

namespace Sipay_Cohorts_HW5.Api.Validator.Genre
{
    public class DeleteGenreCommandValidator:AbstractValidator<DeleteGenreCommand>
    {
        public DeleteGenreCommandValidator()
        {
            RuleFor(x=>x.Id).GreaterThan(0);    
        }
    }
}
