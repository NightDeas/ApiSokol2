using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        public OrderService OrderService { get; set; }
        public ProductService ProductService { get; set; }

        public OrderController(OrderService service, ProductService product)
        {
            OrderService = service;
            ProductService = product;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(WebApi.DTO.Order order)
        {
            return Ok(await OrderService.PostAsync(order));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await OrderService.GetAllAsync());
        }
        [HttpGet("{id:guid}/products")]
        public async Task<IActionResult> GetProducts(Guid id)
        {
            var order = await OrderService.GetAsync(id);
            if (order == null)
                return NotFound();
            order.Products = await OrderService.GetProducts(id);
            return Ok(order);
        }

        [HttpPost("{orderId:guid}/products/add/{productId:guid}/count/{count}")]
        public async Task<IActionResult> PostProduct(Guid orderId, Guid productId, int count)
        {
            if (!await OrderService.AnyAsync(orderId) || !await ProductService.AnyAsync(productId))
                return NotFound();
            if (count == 0)
                return BadRequest("count = 0");
            int productCount = await ProductService.GetCount(productId);
            if (productCount < count)
                return BadRequest("Product Count > count");
            productCount -= count;
            await ProductService.UpdateCountAsync(productId, productCount);

            return Ok(await OrderService.PostProduct(orderId, productId, count));

        }
    }
}
