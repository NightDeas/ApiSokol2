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

        public async Task<Guid> PostProduct(Guid orderId, Guid productId, int count)
        {
            Context.OrderProducts.Add(new()
            {
                OrderId = orderId,
                ProductId = productId,
                ProductCount = count
            });
            await Context.SaveChangesAsync();

            var order = await Context.Orders.FirstOrDefaultAsync(x => x.Id == orderId);
            decimal sum = Context.OrderProducts
                .Include(x => x.Product)
                .Sum(x => x.ProductCount * x.Product.Price);
            order.Sum = sum;

            await Context.SaveChangesAsync();
            return orderId;
        }

        public async Task<bool> AnyAsync(Guid id)
        {
            return await Context.Orders.AnyAsync(x => x.Id == id);
        }

        public async Task<List<Product>> GetProducts(Guid orderId)
        {
            var data = await Context.OrderProducts
                .Include(x=> x.Product)
                .Where(x => x.OrderId == orderId)
                .ToListAsync();

            List<Product> products = new();
            foreach (var product in data)
            {
                products.Add(new()
                {
                    Name = product.Product.Name,
                    Count = product.ProductCount,
                    Price = product.Product.Price,
                    TypeId = product.Product.TypeId,
                    Id = product.Id
                });
            }
            return products;
        }

        public async Task<Order> GetAsync(Guid id)
        {
            return await Context.Orders.FirstOrDefaultAsync(x => x.Id == id);
        }

    }
}
