using Antlr4.Runtime;
using Compilador.API.Token;
using System;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder("int c = 4;");

            AntlrInputStream inputStream = new AntlrInputStream(text.ToString());
            TokenLexer tokenLexer = new TokenLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(tokenLexer);
            TokenParser tokenParser = new TokenParser(commonTokenStream);
            TokenParser.ProgramaContext programaContext = tokenParser.programa();
            TokenVisitor visitor = new TokenVisitor();
            visitor.Visit(programaContext);

            string resultado = "";
            foreach (var item in visitor.Variables)
            {
                resultado += item.Key + " --- " + item.Value + "\n";
            }
            Console.WriteLine("asdadasdasda");
            Console.WriteLine(resultado);
            
        }
    }
}
