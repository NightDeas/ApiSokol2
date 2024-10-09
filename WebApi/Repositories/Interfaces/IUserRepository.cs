using WebApi.Models;

namespace WebApi.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<Guid> PostAsync(User user);

        Task<List<User>> GetAllAsync();
        Task<List<User>> GetAllClientAsync();
        Task<List<User>> GetAllProviderAsync();
    }
}
