﻿using Sipay_Cohorts_HW5.DataAccess.Context;
using Sipay_Cohorts_HW5.Entities.DbSets;

namespace Sipay_Cohorts_HW5.Api.Applications.GenreOperations.Commands
{
    public class CreateGenreCommand
    {
        public CreateGenreModel Model { get; set; }

        private readonly BookStoreDbContext _context;

        public CreateGenreCommand(BookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var genre=_context.Genres.SingleOrDefault(x=>x.Name==Model.Name);
            if (genre != null)
            {
                throw new InvalidOperationException("Kitap türü zaten mevcut");
            }
            genre = new Genre();
            genre.Name = Model.Name;
            _context.Genres.Add(genre);
            _context.SaveChanges();
        }
    }
    public class CreateGenreModel
    {
        public string Name { get; set; }
    }
}
