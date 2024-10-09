namespace WebApi.DTO
{
    public class Product : Interfaces.IConvertModel<Product, WebApi.Models.Product>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid TypeId { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public WebApi.Models.Product ConvertBLLToDALModel(Product DTOModel)
        {
            return new()
            {
                Id = DTOModel.Id,
                Count = DTOModel.Count,
                Name = DTOModel.Name,
                Price = DTOModel.Price,
                TypeId = DTOModel.TypeId,
            };
        }

        public Product ConvertDALToDTOModel(WebApi.Models.Product DALModel)
        {
            return new()
            {
                Id = DALModel.Id,
                Count = DALModel.Count,
                Name = DALModel.Name,
                Price = DALModel.Price,
                TypeId = DALModel.TypeId,
            };
        }
    }
}
