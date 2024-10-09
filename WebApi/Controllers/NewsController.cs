using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using WebApi.DTO;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        public NewsService Service { get; set; }

        public NewsController(NewsService newsService)
        {
            Service = newsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Service.GetNews());
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(NewsPost newsPost)
        {
            return Ok(await Service.PostAsync(newsPost));
        }
    }
}
