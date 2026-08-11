using MiPrimerAPI.Models;

namespace MiPrimerAPI.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync(); // Trae todos los productos
        Task<Product?> GetByIdAsync(int id);      // Trae un producto por ID
        Task AddAsync(Product product);           // Guarda un producto nuevo[cite: 1]
    }
}