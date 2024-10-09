using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        public OrderService Service { get; set; }

        public OrderController(OrderService service)
        {
            Service = service;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(WebApi.DTO.Order order)
        {
            return Ok(await Service.PostAsync(order));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await Service.GetAllAsync());
        }
    }
}
