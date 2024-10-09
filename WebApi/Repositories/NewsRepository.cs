
using Microsoft.EntityFrameworkCore;

using WebApi.Models;
using WebApi.Repositories.Interfaces;

namespace WebApi.Repositories
{
    public class NewsRepository : INewsRepository
    {
        Context Context;

        public NewsRepository(Context context)
        {
            Context = context;
        }

        public async Task<List<News>> GetListAsync()
        {
            return await Context.News.ToListAsync();
        }

        public async Task<Guid> PostAsync(News news)
        {
            news.Created = DateTime.UtcNow;
            await Context.News.AddAsync(news);
            await Context.SaveChangesAsync();
            return news.Id;
        }
    }
}
