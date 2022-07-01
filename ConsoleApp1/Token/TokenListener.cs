using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Token
{
    public class TokenListener: TokenBaseListener
    {
        TokenLexer lexer;
        CommonTokenStream tokens;
        TokenParser parser;
        TokenParser.ProgramaContext tree;
        
        public TokenListener(TokenParser parser)
        {
            this.parser = parser;
            
        }
        public Dictionary<string, object?> Variables { get; } = new();
        public List<object?> Program { get; } = new();
        public List<String> Erros { get; } = new();

        bool error = false;

        public override void EnterEveryRule([NotNull] ParserRuleContext context)
        {
            //context.ExitRule();
            base.EnterEveryRule(context);
        }
        public override void ExitEveryRule([NotNull] ParserRuleContext context)
        {
            if (error)
            {
                Erros.Add(context.exception.Message);
                return;
            }
            
            
            base.ExitEveryRule(context);
        }
    }
}
