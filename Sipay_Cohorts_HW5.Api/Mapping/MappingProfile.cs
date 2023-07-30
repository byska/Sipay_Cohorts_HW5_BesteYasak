using AutoMapper;
using Sipay_Cohorts_HW5.Api.Applications.AuthorOperations.Commands;
using Sipay_Cohorts_HW5.Api.Applications.AuthorOperations.Queries;
using Sipay_Cohorts_HW5.Api.Applications.GenreOperations.Queries;
using Sipay_Cohorts_HW5.Entities.DbSets;
using static Sipay_Cohorts_HW5.Api.Applications.BookOperations.Commands.UpdateBookCommand;
using static Sipay_Cohorts_HW5.Api.Applications.BookOperations.Queries.GetByIdQuery;
using static Sipay_Cohorts_HW5.Api.Applications.GenreOperations.Queries.GetGenreQuery;

namespace Sipay_Cohorts_HW5.Api.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BooksViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name));
            CreateMap<UpdateBookModel, Book>();

            CreateMap<Genre, GenreViewModel>();
            CreateMap<Genre, GenresViewModel>();

            CreateMap<Author,AuthorViewModel>();
            CreateMap<AddAuthorViewModel, Author>();
            CreateMap<Author, AuthorDetailViewModel>();
        }
    }
}
