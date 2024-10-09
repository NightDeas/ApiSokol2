using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks.Dataflow;
using WebApi.DTO;
using WebApi.Repositories;

namespace WebApi.Services
{
    public class OrderService
    {
        OrderRepository Repository;

        public OrderService(OrderRepository repository)
        {
            Repository = repository;
        }

        public async Task<Guid> PostAsync(Order order)
        {
            return await Repository.PostAsync(new Order().ConvertBLLToDALModel(order));
        }

        public async Task<List<DTO.Order>> GetAllAsync()
        {
            var DALModels = await Repository.GetAllAsync();
            var DTOModels = DALModels.Select(x => new DTO.Order().ConvertDALToDTOModel(x)).ToList();
            foreach (var order in DTOModels)
            {
                order.Products = await GetProducts(order.Id);
            }
            return DTOModels;
        }

        public async Task<DTO.Order> GetAsync(Guid id)
        {
            var DALModel = await Repository.GetAsync(id);
            var DTOModel = new Order().ConvertDALToDTOModel(DALModel);
            return DTOModel;
        }

        public async Task<Guid> PostProduct(Guid orderId, Guid productId, int count)
        {
            return await Repository.PostProduct(orderId, productId, count);
        }

        public async Task<bool> AnyAsync(Guid id)
        {
            return await Repository.AnyAsync(id);
        }

        public async Task<List<Product>> GetProducts(Guid orderId)
        {
            var DALModels = await Repository.GetProducts(orderId);
            var DTOModels = DALModels.Select(x => new Product().ConvertDALToDTOModel(x)).ToList();
            return DTOModels;
        }
    }
}
