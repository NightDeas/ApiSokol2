using WebApi.Models;

namespace WebApi.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        Task<bool> AnyAsync(Guid id);
        Task<Order> GetAsync(Guid id);
        Task<Guid> PostAsync(Order order);
        Task<List<Order>> GetAllAsync();
        Task<Guid> PostProduct(Guid orderId, Guid productId, int count);

        Task<List<Product>> GetProducts(Guid orderId);
    }
}
