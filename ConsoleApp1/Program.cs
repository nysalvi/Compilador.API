using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
//using Compilador.API.Token;
using ConsoleApp1.Token;

using System;
using System.IO;
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
            //TokenLexer lexem = new TokenLexer(File.Open("ads", FileMode.Open));
            //CommonTokenStream tokensb  = new CommonTokenStream(lexer);
            String input = "int[4]";

            ICharStream tokenStream = CharStreams.fromString(input);
            ITokenSource lexer = new TokenLexer(tokenStream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            TokenParser tokenParser = new TokenParser(tokens);
            
            IParseTree tree = tokenParser.tipo();            
            TokenListener s;
            IParseTree three = tokenParser.tipo();
            Console.WriteLine(three.ToStringTree(tokenParser));


            TokenLexer Lexer = new TokenLexer(tokenStream);
            CommonTokenStream Tokens = new CommonTokenStream(Lexer);
            TokenParser parser = new TokenParser(Tokens);
            TokenParser.ProgramaContext Tree = parser.programa();
            TokenListener extractor = new TokenListener(parser);
            ParseTreeWalker.Default.Walk(extractor, Tree);

            //var output = tokenVisitor.Visit(tree);
            //Console.WriteLine($"{input} = {output}");            
            /*tokenVisitor.Visit(tree);
            foreach (var item in tokenVisitor.Program)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}
