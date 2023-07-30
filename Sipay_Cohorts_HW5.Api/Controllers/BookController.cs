using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sipay_Cohorts_HW5.Api.Applications.BookOperations.Commands;
using Sipay_Cohorts_HW5.DataAccess.Context;
using Sipay_Cohorts_HW5.Entities.DbSets;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Sipay_Cohorts_HW5.Api.Applications.BookOperations.Queries.GetByIdQuery;
using static Sipay_Cohorts_HW5.Api.Applications.BookOperations.Commands.UpdateBookCommand;
using Sipay_Cohorts_HW5.Api.Applications.BookOperations.Queries;
using Sipay_Cohorts_HW5.Api.Validator.Book;

namespace Sipay_Cohorts_HW5.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public BookController(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            GetByIdQuery query = new GetByIdQuery(_dbContext, _mapper);
            BooksViewModel result = new BooksViewModel();
            query.Id = id;

            GetByIdQueryValidator validator = new GetByIdQueryValidator();
            validator.ValidateAndThrow(query);
            result = query.Handle();

            return Ok(result);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] UpdateBookModel updatedBook)
        {
            UpdateBookCommand command = new UpdateBookCommand(_dbContext);
            command.Model = updatedBook;
            command.Id = id;

            UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();

            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            DeleteBookCommand command = new DeleteBookCommand(_dbContext);
            command.Id = id;

            DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();

            return Ok();
        }
    }
}
