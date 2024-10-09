namespace WebApi.DTO
{
    public class User : Interfaces.IConvertModel<User, WebApi.Models.User>
    {
        public Guid Id { get; set; }
        public bool IsClient { get; set; }
        public decimal Discount { get; set; }
        public bool IsProvider { get; set; }
        public string FIO { get; set; }

        public WebApi.Models.User ConvertBLLToDALModel(User DTOModel)
        {
            return new()
            {
                FIO = DTOModel.FIO,
                Id = DTOModel.Id,
                IsClient = DTOModel.IsClient,
                IsProvider = DTOModel.IsProvider,
                Discount = DTOModel.Discount
            };
        }

        public User ConvertDALToDTOModel(WebApi.Models.User DALModel)
        {
            return new()
            {
                FIO = DALModel.FIO,
                Id = DALModel.Id,
                IsClient = DALModel.IsClient,
                IsProvider = DALModel.IsProvider,
                Discount = DALModel.Discount
            };
        }
    }
}
