using Antlr4.Runtime;
using Compilador.API.Data;
using Compilador.API.Token;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Linq;
namespace Compilador.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Entrada : ControllerBase
    {

        [HttpPost]
        public string LerEntrada(EntradaObjeto obj)
        {
            Compilador c = new Compilador();
            c.Lexico(obj.Mensagem);
            obj.Mensagem = c.mensagem;
            return obj.Mensagem;
        }
    }
}