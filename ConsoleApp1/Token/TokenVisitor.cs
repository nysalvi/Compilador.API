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
            if (context.GetChild(0) is not null && context.GetChild(0) == context.tipo_base())            
                Visit(context.tipo_base());
            else            
                throw new Exception("");
            
            if (context.GetChild(1) is not null && context.GetChild(1) == context.dimensao())
                Visit(context.dimensao());
            else
                throw new Exception("");

            return base.VisitTipo(context);
        }
        public override object VisitDimensao([NotNull] TokenParser.DimensaoContext context)
        {            
            if (context is not null)
            {
                if (context.GetChild(0) is not null && context.GetChild(0) == context.EPSILON())
                    return base.VisitDimensao(context);
                if (context.GetChild(0) is not null && context.GetChild(0) == context.OPEN_BRACKET())
                    Program.Add(context.OPEN_BRACKET().GetText());
                if (context.GetChild(1) is not null && context.GetChild(1) == context.INTEGER())
                    Program.Add(context.INTEGER().GetText());
                if (context.GetChild(2) is not null && context.GetChild(2) == context.CLOSE_BRACKET())
                    Program.Add(context.CLOSE_BRACKET().GetText());
                if (context.GetChild(3) is not null && context.GetChild(3) == context.dimensao())
                    Visit(context.dimensao());
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
