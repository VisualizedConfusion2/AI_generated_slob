using AI_generated_slob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_generated_slob.Service
{
    public class BookService
    {
        private readonly List<Book> _books;

        public BookService()
        {
            _books = new List<Book>
            {
                new Book { BookID = 1, Title = "Clean Code", Author = "Robert C. Martin", Price = 299 },
                new Book { BookID = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Price = 349 },
                new Book { BookID = 3, Title = "Design Patterns", Author = "Erich Gamma", Price = 399 }
            };
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }

        public Book? GetBookById(int id)
        {
            return _books.FirstOrDefault(b => b.BookID == id);
        }
    }
}
