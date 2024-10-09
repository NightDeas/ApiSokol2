using WebApi.Models;

namespace WebApi.Repositories.Interfaces
{
    public interface INewsRepository
    {
        Task<List<News>> GetListAsync();
        Task<Guid> PostAsync(News news);
    }
}
