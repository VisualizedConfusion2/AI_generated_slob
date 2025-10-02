using AI_generated_slob.Models;
using AI_generated_slob.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AI_generated_slob.DatabaseRepo
{
    public class BookRepository : IProductRepository
    {
        private readonly MyLibraryDbContext _context;

        public BookRepository(MyLibraryDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int productId)
        {
            return await _context.Products.FindAsync(productId);
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            var existing = await _context.Products.FindAsync(product.ProductID);
            if (existing != null)
            {
                existing.Title = product.Title;
                existing.Author = product.Author;
                existing.Price = product.Price;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
    }
}