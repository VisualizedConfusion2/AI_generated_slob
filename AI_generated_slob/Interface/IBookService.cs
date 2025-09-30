using AI_generated_slob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_generated_slob.Interface
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book? GetBook(int BookID);
        void CreateBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}
