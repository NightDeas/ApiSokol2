using WebApi.DTO.Interfaces;

namespace WebApi.DTO
{
    public class Order : IConvertModel<Order, WebApi.Models.Order>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public decimal Sum { get; set; }
        public List<Product> Products { get; set; }

        public WebApi.Models.Order ConvertBLLToDALModel(Order DTOModel)
        {
            return new()
            {
                Sum = DTOModel.Sum,
                Id = DTOModel.Id,
                UserId = DTOModel.UserId
            };
        }

        public Order ConvertDALToDTOModel(WebApi.Models.Order DALModel)
        {
            return new()
            {
                Sum = DALModel.Sum,
                Id = DALModel.Id,
                UserId = DALModel.UserId,
            };
        }
    }
}
