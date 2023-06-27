using Application.Service;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContasController : ControllerBase
    {
        [HttpPost("Listar")]
        public IActionResult Index(ContaViewModel contaViewModel)
        {
            ContaViewModel conta = contaViewModel;

            if (conta == null)
            {
                return BadRequest("dados nao informados");
            }
            ContasService contasService = new ContasService();
            List<ContaViewModel> contaUpper =  contasService.ListarContas(conta);

            return Ok(contaUpper);
        }
    }
}
