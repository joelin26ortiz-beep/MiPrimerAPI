using MiPrimerAPI.Models;
using MiPrimerAPI.Repositories;

namespace MiPrimerAPI.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task CreateProductAsync(Product product)
        {
            await _repository.AddAsync(product);
        }
    }
}