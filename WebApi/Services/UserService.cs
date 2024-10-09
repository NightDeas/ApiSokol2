using WebApi.DTO;
using WebApi.Repositories;

namespace WebApi.Services
{
    public class UserService
    {
        UserRepository Repository { get; set; }

        public UserService(UserRepository repository)
        {
            Repository = repository;
        }

        public async Task<Guid> PostAsync(DTO.User user)
        {
            return await Repository.PostAsync(user.ConvertBLLToDALModel(user));
        }

        public async Task<List<DTO.User>> GetAllClientAsync()
        {
            var DALEntities = await Repository.GetAllClientAsync();
            var DTOEntities = DALEntities.Select(x=> new DTO.User().ConvertDALToDTOModel(x)).ToList();
            return DTOEntities;
        }

        public async Task<List<DTO.User>> GetAllProviderAsync()
        {
            var DALEntities = await Repository.GetAllProviderAsync();
            var DTOEntities = DALEntities.Select(x => new DTO.User().ConvertDALToDTOModel(x)).ToList();
            return DTOEntities;
        }
    }
}
