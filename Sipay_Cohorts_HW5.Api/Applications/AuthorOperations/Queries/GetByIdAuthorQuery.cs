using AutoMapper;
using Sipay_Cohorts_HW5.DataAccess.Context;
using Sipay_Cohorts_HW5.Entities.DbSets;

namespace Sipay_Cohorts_HW5.Api.Applications.AuthorOperations.Queries
{
    public class GetByIdAuthorQuery
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;

        public int Id { get; set; }

        public GetByIdAuthorQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public AuthorDetailViewModel Handle()
        {
            var author = _dbContext.Authors.Find(Id);
            if(author == null)
            {
                throw new InvalidOperationException("İlgili id ile bir yazar bulunamadı.");
            }
           AuthorDetailViewModel vm = _mapper.Map<AuthorDetailViewModel>(author);
            return vm;
        }
    }
    public class AuthorDetailViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Book> books { get; set; }
    }
}
