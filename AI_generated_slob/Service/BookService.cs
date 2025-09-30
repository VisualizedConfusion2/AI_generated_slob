using AI_generated_slob.Interface;
using AI_generated_slob.Models;

namespace AI_generated_slob.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _bookRepository.GetAllAsync();
        }

        public async Task<Book?> GetBookAsync(int bookId)
        {
            return await _bookRepository.GetByIdAsync(bookId);
        }

        public async Task CreateBookAsync(Book book)
        {
            if (string.IsNullOrWhiteSpace(book.Title))
                throw new ArgumentException("Book must have a title.");

            if (book.Price < 0)
                throw new ArgumentException("Book price cannot be negative.");

            await _bookRepository.AddAsync(book);
        }

        public async Task UpdateBookAsync(Book book)
        {
            if (book.BookID <= 0)
                throw new ArgumentException("Invalid book ID.");

            await _bookRepository.UpdateAsync(book);
        }

        public async Task DeleteBookAsync(int bookId)
        {
            await _bookRepository.DeleteAsync(bookId);
        }
    }
}