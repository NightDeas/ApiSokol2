using WebApi.Models;

namespace WebApi.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        Task<Guid> PostAsync(Order order);
        Task<List<Order>> GetAllAsync();
    }
}
