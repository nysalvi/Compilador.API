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

        public List<string> Erros;

        public override object VisitPrograma([NotNull] TokenParser.ProgramaContext context)
        {            
            if (context is null)
            {

            }

            if (context.GetChild(0) is not null && context.GetChild(0) != context.funcoes())
                return "";
            if (context.GetChild(0) is not null && context.GetChild(1) != context.principal())
                return "";

            return base.VisitPrograma(context);
        }

        public override object? VisitAtribuicao([NotNull] TokenParser.AtribuicaoContext context)
        {
            var nomeVariavel = context.ID().GetText();
            var value = Visit(context.complemento());            
            Variables[nomeVariavel] = nomeVariavel;
            //return value;
            return base.VisitAtribuicao(context);
        }
        public override object VisitTipo([NotNull] TokenParser.TipoContext context)
        {
            if (context.GetChild(0) is not null && context.GetChild(0) != context.tipo_base())
                return "";
            //Visit(context.tipo_base());
            else
            {

                //context.AddErrorNode();                
            }
            
            if (context.GetChild(1) is not null && context.GetChild(1) != context.dimensao())
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
                {
                    return base.VisitDimensao(context);
                }                    
                if (context.GetChild(0) is not null && context.GetChild(0) == context.OPEN_BRACKET())
                    Program.Add(context.OPEN_BRACKET().GetText());
                else
                {

                }
                if (context.GetChild(1) is not null && context.GetChild(1) == context.INTEGER())
                    Program.Add(context.INTEGER().GetText());
                else
                {

                }
                if (context.GetChild(2) is not null && context.GetChild(2) == context.CLOSE_BRACKET())
                    Program.Add(context.CLOSE_BRACKET().GetText());
                else
                {

                }
                if (context.GetChild(3) is not null && context.GetChild(3) != context.dimensao())
                {

                }                    
            }
            // throw new Exception("");
            return base.VisitDimensao(context);
        }
        public override object VisitComplemento([NotNull] TokenParser.ComplementoContext context)
        {
            //expressao SEMICOLON | funcao SEMICOLON;

            return base.VisitComplemento(context);
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

        public override object VisitOp_aditivo([NotNull] TokenParser.Op_aditivoContext context)
        {

            if (context is null)
                Erros.Add("Nulo");

            if (context.GetChild(0) == context.PLUS())
                Program.Add(context.GetChild(0));
            else if (context.GetChild(0) == context.MINUS())
                Program.Add(context.GetChild(0));
            else
                Erros.Add("esperava: plus | minus");

            return base.VisitOp_aditivo(context);
        }

        public override object VisitExpr_multiplicativa([NotNull] TokenParser.Expr_multiplicativaContext context)
        {

            if (context is null)
                Erros.Add("Nulo");

            if(context.GetChild(0) == context.fator() && context.GetChild(1) == context.expr_multiplicativa2())
            {

                Program.Add(context.GetChild(0));
                Program.Add(context.GetChild(1));

            }
            else
                Erros.Add("esperado: fator && expr_multiplicativa2");

            
            
            return base.VisitExpr_multiplicativa(context);
        }

        public override object VisitExpr_multiplicativa2([NotNull] TokenParser.Expr_multiplicativa2Context context)
        {
            if (context is null)
                Erros.Add("Nulo");

            if (context.GetChild(0) == context.op_multiplicativo() && context.GetChild(1) == context.fator() && context.GetChild(2) == context.expr_multiplicativa2())
            {

                Program.Add(context.GetChild(0));
                Program.Add(context.GetChild(1));
                Program.Add(context.GetChild(2));

            }
            else if (context.GetChild(0) != context.EPSILON())
                Erros.Add("esperado: episilon");
            
            return base.VisitExpr_multiplicativa2(context);
        }

        public override object VisitOp_multiplicativo([NotNull] TokenParser.Op_multiplicativoContext context)
        {
            if (context is null)
                Erros.Add("Nulo");

            if (context.GetChild(0) == context.TIMES())
                Program.Add(context.GetChild(0));
            else if (context.GetChild(0) == context.DIV())
                Program.Add(context.GetChild(0));
            else if (context.GetChild(0) == context.MOD())
                Program.Add(context.GetChild(0));

            else
                Erros.Add("...");

            return base.VisitOp_multiplicativo(context);
        }

        public override object VisitFator([NotNull] TokenParser.FatorContext context)
        {
            if (context is null)
                Erros.Add("Nulo");

            if(context.GetChild(0) == context.sinal() && context.GetChild(1) == context.ID() && context.GetChild(2) == context.vetor())
            {

                Program.Add(context.GetChild(0));
                Program.Add(context.GetChild(1));
                Program.Add(context.GetChild(2));

            }else if(context.GetChild(0) == context.constante())
            {

                Program.Add(context.GetChild(0));

            }else if(context.GetChild(0) == context.NOT() && context.GetChild(1) == context.fator())
            {

                Program.Add(context.GetChild(0));
                Program.Add(context.GetChild(1));

            }else if (context.GetChild(0) == context.OPEN_PARENTHESIS() && context.GetChild(1) == context.expressao() && context.GetChild(2) == context.CLOSE_PARENTHESIS())
            {

                Program.Add(context.GetChild(0));
                Program.Add(context.GetChild(1));
                Program.Add(context.GetChild(2));

            }
            else
            {

                Erros.Add("...");

            }
            
            return base.VisitFator(context);
        }

        public override object VisitVetor([NotNull] TokenParser.VetorContext context)
        {

            if (context is null)
                Erros.Add("Nulo");

            if(context.GetChild(0) == context.OPEN_BRACKET() && context.GetChild(1) == context.expr_aditiva() && context.GetChild(2) == context.CLOSE_BRACKET())
            {

                Program.Add(context.GetChild(0));
                Program.Add(context.GetChild(1));
                Program.Add(context.GetChild(2));

            }else if(context.GetChild(0) != context.EPSILON())
                Erros.Add("esperado : [ sinal | constante | variavel | expressão entre () ]");


            return base.VisitVetor(context);
        }

        public override object VisitConstante([NotNull] TokenParser.ConstanteContext context)
        {
            if (context is null)
                Erros.Add("Nulo");

            if(context.GetChild(0) == context.sinal() && context.GetChild(1) == context.INTEGER() || context.GetChild(0) == context.sinal() && context.GetChild(1) == context.DECIMAL())
            {

                    Program.Add(context.GetChild(0));
                    Program.Add(context.GetChild(1));

            }
            else if(context.GetChild(0) == context.TEXT())
                    Program.Add(context.TEXT().GetText());

            return base.VisitConstante(context);
        }

        public override object VisitSinal([NotNull] TokenParser.SinalContext context)
        {
            if (context is null)
                Erros.Add("nulo");

            if (context.GetChild(0) == context.PLUS() || context.GetChild(0) == context.MINUS()) { 
            
                Program.Add(context.GetChild(0).GetText());
            
            }else if(context.GetChild(0) != context.EPSILON())
                Erros.Add("esperado : + | -");

            
            return base.VisitSinal(context);
        }
    }
}
