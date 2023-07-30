﻿using FluentValidation;
using Sipay_Cohorts_HW5.Api.Applications.BookOperations.Queries;

namespace Sipay_Cohorts_HW5.Api.Validator.Book
{
    public class GetByIdQueryValidator : AbstractValidator<GetByIdQuery>
    {
        public GetByIdQueryValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0);
        }
    }
}
