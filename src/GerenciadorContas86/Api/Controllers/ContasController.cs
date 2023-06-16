using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class ContasController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
