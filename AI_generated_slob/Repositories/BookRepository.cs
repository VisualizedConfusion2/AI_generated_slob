using AI_generated_slob.Interface;
using AI_generated_slob.Models;
using Microsoft.EntityFrameworkCore;

namespace AI_generated_slob.DatabaseRepo
{
    public class BookRepository : IBookRepository
    {
        private readonly MyLibraryDbContext _context;

        public BookRepository(MyLibraryDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book?> GetByIdAsync(int bookId)
        {
            return await _context.Books.FindAsync(bookId);
        }

        public async Task AddAsync(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Book book)
        {
            var existing = await _context.Books.FindAsync(book.BookID);
            if (existing != null)
            {
                existing.Title = book.Title;
                existing.Author = book.Author;
                existing.Price = book.Price;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int bookId)
        {
            var book = await _context.Books.FindAsync(bookId);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }
    }
}