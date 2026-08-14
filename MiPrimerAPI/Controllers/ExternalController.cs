using Microsoft.AspNetCore.Mvc;
using MiPrimerAPI.Services;

namespace MiPrimerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExternalController : ControllerBase
    {
        private readonly ExternalApiService _externalApiService;

        public ExternalController(ExternalApiService externalApiService)
        {
            _externalApiService = externalApiService;
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _externalApiService.GetUsersAsync();
            return Ok(users);
        }
    }
}