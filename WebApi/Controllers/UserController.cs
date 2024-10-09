using Microsoft.AspNetCore.Mvc;

using System.Reflection.Metadata.Ecma335;

using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserService Service { get; set; }

        public UserController(UserService service)
        {
            Service = service;
        }

        [HttpPost("registration/")]
        public async Task<IActionResult> Post([FromBody] WebApi.DTO.User User)
        {
            return Ok(await Service.PostAsync(User));
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Service.GetAllAsync());
        }

        [HttpGet("clients")]
        public async Task<IActionResult> GetAllClients()
        {
            return Ok(await Service.GetAllClientAsync());
        }

        [HttpGet("providers")]
        public async Task<IActionResult> GetAllProviders()
        {
            return Ok(await Service.GetAllProviderAsync());
        }

        [HttpPut("discount/set")]
        public async Task<IActionResult> SetDiscount(Guid userId, decimal newDiscount)
        {
            if (!await Service.AnyAsync(userId))
                return NotFound("User not found");
            if (newDiscount < 0)
                return BadRequest("discount < 0");
           return Ok(await Service.SetDiscount(userId, newDiscount));
        }

        [HttpPut("discount/update")]
        public async Task<IActionResult> AppendDiscount(Guid userId, decimal discount)
        {
            if (!await Service.AnyAsync(userId))
                return NotFound("User not found");
            if (discount < 0)
                return BadRequest("discount < 0");
            return Ok(await Service.AppendDiscount(userId, discount));
        }
    }
}
