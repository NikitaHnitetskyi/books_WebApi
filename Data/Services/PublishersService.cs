using my_books.Data.Models.ViewModels;
using my_books.Data.Models;
using System;

namespace my_books.Data.Services
{
    public class PublishersService
    {
        private AppDbContext _context;

        public PublishersService(AppDbContext context)
        {
            _context = context;
        }

        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.FullName
            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }
    }
}

