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
            var DTOModels = DALModels.Select(x=> new DTO.Order().ConvertDALToDTOModel(x)).ToList();
            return DTOModels;
        }
    }
}
