using Compilador.API.Data;
using Microsoft.AspNetCore.Mvc;

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