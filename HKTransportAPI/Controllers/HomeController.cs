using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HKTransportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // Action pour la page par défaut
        [HttpGet]
        public IActionResult GetWelcomeMessage()
        {
            return Ok("Bienvenu sur HKTransportAPI");
        }
    }
}
