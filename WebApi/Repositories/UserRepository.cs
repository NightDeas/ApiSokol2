
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

        public Task<User> GetAsync(Guid id)
        {
            return Context.Users.FirstOrDefaultAsync(x => x.Id == id);
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


        public async Task<decimal?> SetDiscount(Guid id, decimal discount)
        {
            var user = await GetAsync(id);
            if (user == null)
                return -1;
            user.Discount = discount;
            Context.Update(user);
            await Context.SaveChangesAsync();
            return user.Discount;
        }

        public async Task<decimal?> AppendDiscount(Guid id, decimal discount)
        {
            var user = await GetAsync(id);
            if (user == null)
                return -1;
            user.Discount += discount;
            Context.Update(user);
            await Context.SaveChangesAsync();
            return user.Discount;
        }

        public async Task<bool> AnyAsync(Guid id)
        {
            return await Context.Users.AnyAsync(x => x.Id == id);
        }
    }
}
