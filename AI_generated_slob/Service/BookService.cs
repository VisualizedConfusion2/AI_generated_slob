using AI_generated_slob.Models;
using AI_generated_slob.Repositories;

namespace AI_generated_slob.Service
{
    public class BookService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public BookService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product?> GetProductAsync(int productId)
        {
            return await _productRepository.GetByIdAsync(productId);
        }

        public async Task CreateProductAsync(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Title))
                throw new ArgumentException("Product must have a title.");

            if (product.Price < 0)
                throw new ArgumentException("Product price cannot be negative.");

            await _productRepository.AddAsync(product);
        }

        public async Task UpdateProductAsync(Product product)
        {
            if (product.ProductID <= 0)
                throw new ArgumentException("Invalid product ID.");

            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProductAsync(int productId)
        {
            await _productRepository.DeleteAsync(productId);
        }

        public async Task<Product> Product(int productId)
        {
            // Implementation to satisfy IProductService interface.
            // Reuse GetProductAsync logic, but ensure non-null return as per interface.
            var product = await GetProductAsync(productId);
            if (product == null)
                throw new KeyNotFoundException($"Product with ID {productId} not found.");
            return product;
        }
    }
}