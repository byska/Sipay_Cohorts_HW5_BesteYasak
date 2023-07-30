using FluentValidation;
using Sipay_Cohorts_HW5.Api.Applications.BookOperations.Commands;

namespace Sipay_Cohorts_HW5.Api.Validator.Book
{
    public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
    {
        public DeleteBookCommandValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0);
        }
    }
}
