using Cadastro.Api2.Models;
using Cadastro.Api2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Api2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        CadastroService cadastroService = new CadastroService();

        [HttpPost]
        [Route("Create")]
        public Usuario_Endereco Create(Usuario_Endereco usuario_Endereco)
        {
            var resp = cadastroService.Create(usuario_Endereco);
            return resp;
        }
    }
}
