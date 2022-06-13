using Antlr4.Runtime;
using Antlr4;

using System.Text;

namespace Compilador.API.Controllers
{
    public class Compilador2
    {
        
        public void Lexico(string args)
        {
            StringBuilder text = new StringBuilder(args);

            AntlrInputStream inputStream = new AntlrInputStream(text.ToString());
            //Token speakLexer = new Token(inputStream);
            //SpeakParser
        }
    }
}
