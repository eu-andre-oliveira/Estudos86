using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContasController : ControllerBase
    {
        [HttpGet("Listar")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
