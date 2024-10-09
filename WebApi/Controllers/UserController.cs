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
    }
}
