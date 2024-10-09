namespace WebApi.DTO
{
    public class TypeProduct : Interfaces.IConvertModel<TypeProduct, WebApi.Models.TypeProduct>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public WebApi.Models.TypeProduct ConvertBLLToDALModel(TypeProduct DTOModel)
        {
            return new()
            {
                Name = DTOModel.Name,
                Id = DTOModel.Id
            };
        }

        public TypeProduct ConvertDALToDTOModel(WebApi.Models.TypeProduct DALModel)
        {
            return new()
            {
                Name = DALModel.Name,
                Id = DALModel.Id
            };
        }
    }
}
