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
            /*var tipo =*/ Visit(context.tipo_base());
            //Program.Add(tipo);
            /*var dimensao =*/ Visit(context.dimensao());
            return base.VisitTipo(context);            
        }
        public override object VisitDimensao([NotNull] TokenParser.DimensaoContext context)
        {
            if (context.OPEN_BRACKET() != null)
                Program.Add(context.OPEN_BRACKET().GetText());
            if (context.INTEGER() != null)
                Program.Add(context.INTEGER().GetText());
            if (context.CLOSE_BRACKET() != null)
                Program.Add(context.CLOSE_BRACKET().GetText());
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
    }
}
