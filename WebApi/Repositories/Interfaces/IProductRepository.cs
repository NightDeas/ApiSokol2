using WebApi.Models;

namespace WebApi.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<bool> AnyAsync(Guid id);
        Task<Product> GetAsync(Guid id);
        Task<List<Product>> GetAllAsync();
        Task<Guid> PostAsync(Product product);
        Task<int> UpdateCountAsync(Guid id, int newCount);
        Task<int> GetCount(Guid id);
    }
}
