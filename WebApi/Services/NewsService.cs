using System.Threading.Tasks.Dataflow;

using WebApi.DTO;
using WebApi.Repositories;

namespace WebApi.Services
{
    public class NewsService
    {
        public NewsRepository Repository { get; set; }

        public NewsService(NewsRepository repository)
        {
            Repository = repository;
        }

        public async Task<List<DTO.News>> GetNews()
        {
            var DALModels = await Repository.GetListAsync();
            var DTOModels = DALModels.Select(x => new DTO.News().ConvertDALToDTOModel(x)).ToList();
            return DTOModels;
        }

        public async Task<Guid> PostAsync(NewsPost newsPost)
        {
            var DALModel = new Models.News()
            {
                Created = DateTime.Now,
                Description = newsPost.Description,
                Title = newsPost.Title,
            };
            return await Repository.PostAsync(DALModel);
        }
    }
}
