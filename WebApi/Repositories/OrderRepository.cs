using Microsoft.EntityFrameworkCore;

using WebApi.Models;
using WebApi.Repositories.Interfaces;

namespace WebApi.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        Context Context;

        public OrderRepository(Context context)
        {
            Context = context;
        }

        public async Task<Guid> PostAsync(Order order)
        {
            var newOrder = new Order()
            {
                Count = order.Count,
                ProductId = order.ProductId,
                UserId = order.UserId,
                Sum = order.Sum,
            };
            await Context.Orders.AddAsync(newOrder);
            await Context.SaveChangesAsync();
            return newOrder.Id;
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await Context.Orders.ToListAsync();
        }
    }
}
