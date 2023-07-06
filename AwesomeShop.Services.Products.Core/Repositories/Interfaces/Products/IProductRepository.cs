using AwesomeShop.Services.Products.Core.Entities;

namespace AwesomeShop.Services.Products.Core.Repositories.Interfaces.Products;

public interface IProductRepository
{
    Task<List<Product>> GetAllAsync();
    Task<Product> GetByIdAsync(Guid id);
    Task AddAsync(Product product);
    Task UpdateAsync(Product product);
}