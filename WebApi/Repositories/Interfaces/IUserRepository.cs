using WebApi.Models;

namespace WebApi.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<Guid> PostAsync(User user);
        Task<User> GetAsync(Guid id);
        Task<decimal> SetDiscount(Guid id, decimal discount);
        Task<decimal> AppendDiscount(Guid id, decimal discount);
        Task<List<User>> GetAllAsync();
        Task<List<User>> GetAllClientAsync();
        Task<List<User>> GetAllProviderAsync();
        Task<bool> AnyAsync(Guid id);
    }
}
