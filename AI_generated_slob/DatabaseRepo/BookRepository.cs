using AI_generated_slob.Interface;
using AI_generated_slob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_generated_slob.DatabaseRepo
{
    public class BookRepository : IBookRepository
    {
        private readonly MyLibraryDbContext _context;

        public BookRepository(MyLibraryDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public Book? GetById(int id)
        {
            return _context.Books.Find(id);
        }

        public void Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Update(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = _context.Books.Find(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }

        IEnumerable<Book> IBookRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        Book? IBookRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
