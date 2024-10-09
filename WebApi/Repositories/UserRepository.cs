
using Microsoft.EntityFrameworkCore;

using WebApi.Models;
using WebApi.Repositories.Interfaces;

namespace WebApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        Context Context;

        public UserRepository(Context context)
        {
            Context = context;
        }

        public Task<List<User>> GetAllAsync()
        {
            return Context.Users.AsNoTracking().ToListAsync();
        }

        public Task<List<User>> GetAllClientAsync()
        {
            return Context.Users
                .AsNoTracking()
                .Where(x => x.IsClient == true)
                .ToListAsync();
        }

        public Task<List<User>> GetAllProviderAsync()
        {
            return Context.Users
                          .AsNoTracking()
                          .Where(x => x.IsProvider == true)
                          .ToListAsync();
        }

        public async Task<Guid> PostAsync(User user)
        {
            var newUser = new User()
            {
                FIO = user.FIO,
                IsClient = user.IsClient,
                IsProvider = user.IsProvider,
            };
            await Context.AddAsync(newUser);
            await Context.SaveChangesAsync();
            return newUser.Id;
        }


    }
}
