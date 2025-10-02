using AI_generated_slob.Models;

namespace AI_generated_slob.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int ProductId);
        Task AddAsync(Product product);
        Task UpdateAsync(Product prouct);
        Task DeleteAsync(int productId);
    }
}