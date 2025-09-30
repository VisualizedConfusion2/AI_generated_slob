using AI_generated_slob.Models;

namespace AI_generated_slob.Interface
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(int bookId);
        Task AddAsync(Book book);
        Task UpdateAsync(Book book);
        Task DeleteAsync(int bookId);
    }
}