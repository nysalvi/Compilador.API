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

        public List<String> Erros { get; } = new();
               
        public override object VisitPrograma([NotNull] TokenParser.ProgramaContext context)
        {            
            if (context is null)
                Erros.Add("Programa não pode ser Nulo!");
            if (context.GetChild(0) != context.funcoes())
                Erros.Add("Esperava produção 'funcoes'");

            if (context.GetChild(1) != context.principal())
                Erros.Add("O Programa deve ter a função main");

            return base.VisitPrograma(context);
        }
        public override object VisitFuncoes([NotNull] TokenParser.FuncoesContext context)
        {
            if (context.GetChild(0) == context.EPSILON())
                return base.VisitFuncoes(context);

            if (context.GetChild(0) != context.dec_funcao())
                Erros.Add("Esperava produção 'dec funcao'!");
            if (context.GetChild(1) != context.funcoes())
                Erros.Add("Esperava produção 'funcoes'!");

            return base.VisitFuncoes(context);
        }
        public override object VisitDec_funcao([NotNull] TokenParser.Dec_funcaoContext context)
        {
            if (context.GetChild(0) != context.tipo_retorno())
                Erros.Add("Esperava produção 'tipo retorno'!");
            if (context.GetChild(1) != context.ID())
                Erros.Add("Esperava token ID");
            else
                Program.Add(context.GetChild(1).GetText());

            if (context.GetChild(2) != context.OPEN_PARENTHESIS())
                Erros.Add("Esperava token '('");
            else
                Program.Add(context.GetChild(2).GetText());

            if (context.GetChild(3) != context.parametros())
                Erros.Add("Esperava produção 'parametros'!");

            if (context.GetChild(4) != context.CLOSE_PARENTHESIS())
                Erros.Add("Esperava token ')'");
            else
                Program.Add(context.GetChild(4).GetText());

            if (context.GetChild(5) != context.bloco())
                Erros.Add("Esperava produção 'bloco'");

            return base.VisitDec_funcao(context);
        }
        public override object VisitTipo_retorno([NotNull] TokenParser.Tipo_retornoContext context)
        {
            if (context.GetChild(0) != context.tipo() && context.GetChild(0) != context.VOID())
                Erros.Add("Esperava produção 'tipo' ou token 'void'!");
            else if (context.GetChild(0) == context.VOID())
                Program.Add(context.GetChild(0));
               
            return base.VisitTipo_retorno(context);
        }
        public override object VisitTipo([NotNull] TokenParser.TipoContext context)
        {
            if (context.GetChild(0) != context.tipo_base())
                Erros.Add("Tipo deve começar com a produção 'tipo base'!");

            if (context.GetChild(1) != context.dimensao())
                Erros.Add("Esperava a Produção 'dimensão' ou token epsilon!");

            return base.VisitTipo(context);
        }
        public override object VisitTipo_base([NotNull] TokenParser.Tipo_baseContext context)
        {
            if (context.INT() != null)
            {
                Program.Add(context.INT().GetText());
                return base.VisitTipo_base(context);
            }

            if (context.BOOLEAN() != null)
            {
                Program.Add(context.BOOLEAN().GetText());
                return base.VisitTipo_base(context);
            }            
            
            if (context.FLOAT() != null)
            {
                Program.Add(context.FLOAT().GetText());
                return base.VisitTipo_base(context);
            }
            
            
            if (context.CHAR() != null)
            {
                //IParserErrorListener d = new BaseErrorListener();
                Program.Add(context.CHAR().GetText());
                return base.VisitTipo_base(context);
            }
            Erros.Add("Esperava um tipo base 'char', 'float', 'int' ou 'boolean'");
            
            return base.VisitTipo_base(context);
        }
        public override object VisitDimensao([NotNull] TokenParser.DimensaoContext context)
        {
            if (context is not null)
            {
                if (context.GetChild(0) is not null && context.GetChild(0) == context.EPSILON())
                    return base.VisitDimensao(context);
                if (context.GetChild(0) is not null && context.GetChild(0) == context.OPEN_BRACKET())
                    Program.Add(context.OPEN_BRACKET().GetText());
                else
                {
                    Erros.Add("Dimensao Esperava '['");
                }
                if (context.GetChild(1) is not null && context.GetChild(1) == context.INTEGER())
                    Program.Add(context.INTEGER().GetText());
                else
                {
                    Erros.Add("Dimensao Esperava 'INTEGER'");
                }
                if (context.GetChild(2) is not null && context.GetChild(2) == context.CLOSE_BRACKET())
                    Program.Add(context.CLOSE_BRACKET().GetText());
                else
                {
                    Erros.Add("Dimensao Esperava ']'");
                }
                if (context.GetChild(3) is not null && context.GetChild(3) != context.dimensao())
                {
                    Erros.Add("Esperava produção 'dimensao' ou token 'epsilon'");
                }
            }
            return base.VisitDimensao(context);
        }
        public override object VisitExpr_ou([NotNull] TokenParser.Expr_ouContext context)
        {
            if (context.GetChild(0) != context.expr_e())
                Erros.Add("Esperava produção 'expr_e'");
            if (context.GetChild(1) != context.expr_ou2())
                Erros.Add("Esperava produção 'expr_ou2'");
            return base.VisitExpr_ou(context);
        }
        public override object VisitExpr_ou2([NotNull] TokenParser.Expr_ou2Context context)
        {
            if (context.GetChild(0) == context.EPSILON())
                return base.VisitExpr_ou2(context);

            if (context.GetChild(0) != context.OR())
                Erros.Add("Esperava token '||'");

            if (context.GetChild(1) != context.expr_e())
                Erros.Add("Esperava produção 'expr_e'");
            if (context.GetChild(2) != context.expr_e())
                Erros.Add("Esperava produção 'expr_ou2'");
            return base.VisitExpr_ou2(context);
        }
        public override object VisitExpr_e([NotNull] TokenParser.Expr_eContext context)
        {
            if (context.GetChild(0) == context.expr_relacional())
                Erros.Add("Esperava produção 'expr_relacional'");
            if (context.GetChild(0) != context.expr_e2())
                Erros.Add("Esperava produção 'expr_e2'");
            return base.VisitExpr_e(context);
        }
        public override object VisitExpr_e2([NotNull] TokenParser.Expr_e2Context context)
        {
            if (context.GetChild(0) == context.EPSILON())
                return base.VisitExpr_e2(context);
            if (context.GetChild(0) == context.AND())
                Erros.Add("Esperava produção 'expr_relacional'");
            if (context.GetChild(1) != context.expr_relacional())
                Erros.Add("Esperava produção 'expr_e2'");
            return base.VisitExpr_e2(context);
        }
    }
}
