using WebApi.DTO.Interfaces;

namespace WebApi.DTO
{
    public class News : IConvertModel<News, Models.News>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;

        public Models.News ConvertBLLToDALModel(News DTOModel)
        {
            return new()
            {
                Created = DTOModel.Created,
                Description = DTOModel.Description,
                Id = DTOModel.Id,
                Title = DTOModel.Title,
            };
        }

        public News ConvertDALToDTOModel(Models.News DALModel)
        {
            return new()
            {
                Created = DALModel.Created,
                Description = DALModel.Description,
                Id = DALModel.Id,
                Title = DALModel.Title,
            };
        }

        public Models.News ConvertPostModelToDTO(NewsPost newsPost)
        {
            return new()
            {
                Created = DateTime.Now,
                Title = newsPost.Title,
                Description = newsPost.Description,
            };
        }
    }
}
