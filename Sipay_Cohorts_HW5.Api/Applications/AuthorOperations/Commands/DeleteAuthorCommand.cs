using Microsoft.EntityFrameworkCore;
using Sipay_Cohorts_HW5.DataAccess.Context;

namespace Sipay_Cohorts_HW5.Api.Applications.AuthorOperations.Commands
{
    public class DeleteAuthorCommand
    {
        public int Id { get; set; }

        private readonly BookStoreDbContext _dbContext;

        public DeleteAuthorCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {
            var author = _dbContext.Authors.Include(x=>x.Books).FirstOrDefault(x=>x.Id==Id);
            if (author == null)
                throw new InvalidOperationException("Verilen id ile bir yazar bulunmamaktadır.");
            if (author.Books != null)
                throw new InvalidOperationException("Yazarı silebilmek için önce yazarın kitaplarını silmelisiniz.");

            _dbContext.Authors.Remove(author);
            _dbContext.SaveChanges();
        }
    }
}
