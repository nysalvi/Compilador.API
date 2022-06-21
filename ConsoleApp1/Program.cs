using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Compilador.API.Token;
using System;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder("void main(){int c = 4;}");
            /*
                AntlrInputStream inputStream = new AntlrInputStream(text.ToString());
                TokenLexer tokenLexer = new TokenLexer(inputStream);
                CommonTokenStream commonTokenStream = new CommonTokenStream(tokenLexer);
                TokenParser tokenParser = new TokenParser(commonTokenStream);
                TokenParser.TipoContext programaContext = tokenParser.tipo();            
                TokenVisitor visitor = new TokenVisitor();
                visitor.Visit(programaContext);
                
                foreach (var item in visitor.Variables)
                {
                    resultado += item.Key + " --- " + item.Value + "\n";
                }
                foreach (var item in visitor.Program)
                {
                    resultado += item + "\n";  
                }
                Console.WriteLine();
                Console.WriteLine("asdadasdasda");
                Console.WriteLine(resultado);
            */
            String input = "int[4]";
            ICharStream tokenStream = CharStreams.fromString(input);
            ITokenSource lexer = new TokenLexer(tokenStream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            TokenParser tokenParser = new TokenParser(tokens);
            IParseTree tree = tokenParser.tipo();
            TokenVisitor tokenVisitor = new TokenVisitor();
            //var output = tokenVisitor.Visit(tree);
            //Console.WriteLine($"{input} = {output}");            
            tokenVisitor.Visit(tree);
            foreach (var item in tokenVisitor.Program)
            {
                Console.WriteLine(item);
            }
        }
    }
}
