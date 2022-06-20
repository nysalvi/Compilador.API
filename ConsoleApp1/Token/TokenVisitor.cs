using Antlr4.Runtime.Misc;
using System.Collections.Generic;

namespace Compilador.API.Token
{
    public class TokenVisitor : TokenBaseVisitor<object?>
    {
        public Dictionary<string, object?> Variables { get; } = new();
        public override object? VisitAtribuicao([NotNull] TokenParser.AtribuicaoContext context)
        {
            var nomeVariavel = context.ID().GetText();
            var value = Visit(context.complemento());

            return null;
            Variables[nomeVariavel] = value;
        }
        public override object VisitTipo_base([NotNull] TokenParser.Tipo_baseContext context)
        {
            if (context.INT() != null)            
                return context.INT().GetText();            
            if (context.BOOLEAN() != null)
                return context.BOOLEAN().GetText();
            if (context.FLOAT() != null)
                return context.FLOAT().GetText();
            if (context.CHAR() != null)
                return context.CHAR().GetText()[1..^1];
            if (context.BOOLEAN() != null)
            {
                return context.BOOLEAN().GetText() == "true";
            }

            return null;
            //throw new NotImplementedException();
        }
    }
}
