using WebApi.DTO.Interfaces;

namespace WebApi.DTO
{
    public class OrderProducts : IConvertModel<OrderProducts, Models.OrderProducts>
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int ProductCount { get; set; }

        public Models.OrderProducts ConvertBLLToDALModel(OrderProducts DTOModel)
        {
            return new()
            {
                Id = DTOModel.Id,
                OrderId = DTOModel.OrderId,
                ProductCount = DTOModel.ProductCount,
                ProductId = DTOModel.ProductId,
            };
        }

        public OrderProducts ConvertDALToDTOModel(Models.OrderProducts DALModel)
        {
            return new()
            {
                OrderId = DALModel.Id,
                ProductCount = DALModel.ProductCount,
                ProductId = DALModel.ProductId,
                Id = DALModel.ProductId,
            };
        }
    }

    public class OrderProductPost
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int ProductCount { get; set; }
    }
}
