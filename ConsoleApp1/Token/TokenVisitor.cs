using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;

namespace Compilador.API.Token
{
    public class TokenVisitor : TokenBaseVisitor<object?>
    {
        public Dictionary<string, object?> Variables { get; } = new();
        public List<object?> Program { get; } = new();
        public override object? VisitAtribuicao([NotNull] TokenParser.AtribuicaoContext context)
        {
            var nomeVariavel = context.ID().GetText();
            var value = Visit(context.complemento());            
            Variables[nomeVariavel] = value;

            return value;
        }
        public override object VisitTipo([NotNull] TokenParser.TipoContext context)
        {
            var lex = context.tipo_base();
            if (lex is not null)
            {
                if (lex.BOOLEAN() is not null)
                    Program.Add(lex.BOOLEAN());                    
                else if (lex.INT() is not null)
                    Program.Add(lex.INT());
                else if (lex.CHAR() is not null)
                    Program.Add(lex.CHAR());
                else if (lex.FLOAT() is not null)
                    Program.Add(lex.FLOAT());
                else
                    throw new Exception("");
            }
            // throw new Exception("");
            return base.VisitTipo(context);            
        }
        public override object VisitDimensao([NotNull] TokenParser.DimensaoContext context)
        {
            var lex = context.dimensao();
            
            if (lex is not null)
            {
                if (lex.GetChild(0) is not null && lex.GetChild(0) == lex.EPSILON())
                    return base.VisitDimensao(context);
                if (lex.GetChild(0) is not null && lex.GetChild(0) == lex.OPEN_BRACKET())
                    Program.Add(lex.OPEN_BRACKET().GetText());
                if (lex.GetChild(1) is not null && lex.GetChild(1) == lex.INTEGER())
                    Program.Add(lex.INTEGER().GetText());
                if (lex.GetChild(2) is not null && lex.GetChild(2) == lex.CLOSE_BRACKET())
                    Program.Add(lex.CLOSE_BRACKET().GetText());
                if (lex.GetChild(3) is not null && lex.GetChild(3) == lex.dimensao())
                    Visit(lex.dimensao());

            }
            // throw new Exception("");
            return base.VisitDimensao(context);
        }
        public override object VisitTipo_base([NotNull] TokenParser.Tipo_baseContext context)
        {
            if (context.INT() != null)
            {
                Program.Add(context.INT().GetText());
                //return context.INT().GetText();            
            }        
            if (context.BOOLEAN() != null)
            {
                Program.Add(context.BOOLEAN().GetText());
                //return context.BOOLEAN().GetText();
            }
            if (context.FLOAT() != null)
            {
                Program.Add(context.FLOAT().GetText());
                //return context.FLOAT().GetText();
            }
            if (context.CHAR() != null)
            {
                Program.Add(context.CHAR().GetText());
                //return context.CHAR().GetText()[1..^1];
            }
            return base.VisitTipo_base(context);
        }
        private bool IsNull(ParserRuleContext parserRuleContext)
        {
            return parserRuleContext is null;
        }
    }
}
