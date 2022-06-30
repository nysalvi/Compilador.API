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

        public List<string> Erros = new List<string>();

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

        public override object VisitExpr_relacional([NotNull] TokenParser.Expr_relacionalContext context)
        {
            if (context is null)
                Erros.Add("Nulo");

            if(context.GetChild(0) == context.expr_aditiva() && context.GetChild(1) == context.expr_relacional2())
            {

                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());

            }
            else
            {

                Erros.Add("esperado: expr_aditiva && epr_relacional2");

            }


            return base.VisitExpr_relacional(context);
        }

        public override object VisitExpr_relacional2([NotNull] TokenParser.Expr_relacional2Context context)
        {

            if (context is null)
                Erros.Add("Nulo");

            if (context.GetChild(0) == context.COMP() && context.GetChild(1) == context.expr_aditiva() && context.GetChild(2) == context.expr_relacional2())
            {

                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());

            }
            else
                Erros.Add("esperado: comp && expr_aditiva && exxpr_relacional");

            return base.VisitExpr_relacional2(context);
        }

        public override object VisitExpr_aditiva([NotNull] TokenParser.Expr_aditivaContext context)
        {
            if (context is null)
                Erros.Add("Nulo");

            if (context.GetChild(0) == context.expr_multiplicativa() && context.GetChild(1) == context.expr_aditiva2())
            {

                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());

            }
            else
                Erros.Add("esperado: expr_multiplicativa && exxpr_aditiva2");

            return base.VisitExpr_aditiva(context);
        }

        public override object VisitExpr_aditiva2([NotNull] TokenParser.Expr_aditiva2Context context)
        {
            if (context is null)
                Erros.Add("Nulo");

            if (context.GetChild(0) == context.op_aditivo() && context.GetChild(1) == context.expr_multiplicativa() && context.GetChild(2) == context.expr_aditiva2())
            {

                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());

            }
            else if (context.GetChild(0) != context.EPSILON())
                Erros.Add("esperado: op_aditivo && expr_multiplicativo && expr_aditiva2");

            return base.VisitExpr_aditiva2(context);
        }

        public override object VisitOp_aditivo([NotNull] TokenParser.Op_aditivoContext context)
        {

            if (context is null)
                Erros.Add("Nulo");

            if (context.GetChild(0) == context.PLUS())
                Program.Add(context.GetChild(0).GetText());
            else if (context.GetChild(0) == context.MINUS())
                Program.Add(context.GetChild(0).GetText());
            else
                Erros.Add("esperava: plus | minus");

            return base.VisitOp_aditivo(context);
        }

        public override object VisitExpr_multiplicativa([NotNull] TokenParser.Expr_multiplicativaContext context)
        {

            if (context is null)
                Erros.Add("Nulo");

            if (context.GetChild(0) == context.fator() && context.GetChild(1) == context.expr_multiplicativa2())
            {

                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());

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

                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());

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
                Program.Add(context.GetChild(0).GetText());
            else if (context.GetChild(0) == context.DIV())
                Program.Add(context.GetChild(0).GetText());
            else if (context.GetChild(0) == context.MOD())
                Program.Add(context.GetChild(0).GetText());

            else
                Erros.Add("...");

            return base.VisitOp_multiplicativo(context);
        }

        public override object VisitFator([NotNull] TokenParser.FatorContext context)
        {
            if (context is null)
                Erros.Add("Nulo");

            if (context.GetChild(0) == context.sinal() && context.GetChild(1) == context.ID() && context.GetChild(2) == context.vetor())
            {

                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());

            } else if (context.GetChild(0) == context.constante())
            {

                Program.Add(context.GetChild(0).GetText());

            } else if (context.GetChild(0) == context.NOT() && context.GetChild(1) == context.fator())
            {

                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());

            } else if (context.GetChild(0) == context.OPEN_PARENTHESIS() && context.GetChild(1) == context.expressao() && context.GetChild(2) == context.CLOSE_PARENTHESIS())
            {

                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());

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

            if (context.GetChild(0) == context.OPEN_BRACKET() && context.GetChild(1) == context.expr_aditiva() && context.GetChild(2) == context.CLOSE_BRACKET())
            {

                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());

            } else if (context.GetChild(0) != context.EPSILON())
                Erros.Add("esperado : [ sinal | constante | variavel | expressão entre () ]");


            return base.VisitVetor(context);
        }

        public override object VisitConstante([NotNull] TokenParser.ConstanteContext context)
        {
            if (context is null)
                Erros.Add("Nulo");

            if (context.GetChild(0) == context.sinal() && context.GetChild(1) == context.INTEGER() || context.GetChild(0) == context.sinal() && context.GetChild(1) == context.DECIMAL())
            {

                Program.Add(context.GetChild(0));
                Program.Add(context.GetChild(1));

            }
            else if (context.GetChild(0) == context.TEXT())
                Program.Add(context.TEXT().GetText());

            return base.VisitConstante(context);
        }

        public override object VisitSinal([NotNull] TokenParser.SinalContext context)
        {
            if (context is null)
                Erros.Add("nulo");

            if (context.GetChild(0) == context.PLUS())
                Program.Add(context.GetChild(0).GetText());
            else if(context.GetChild(0) == context.MINUS())
            if (context.GetChild(0) == context.PLUS() || context.GetChild(0) == context.MINUS()) {

                Program.Add(context.GetChild(0).GetText());
            else if(context.GetChild(0) != context.EPSILON())

            } else if (context.GetChild(0) != context.EPSILON())
                Erros.Add("esperado : + | -");


            return base.VisitSinal(context);
        }

        #region modulo lucas

        //TODO: Implementar Dimensao - L12
        public override object VisitParametros([NotNull] TokenParser.ParametrosContext context)
        {
            if (context is null)
                Erros.Add("nulo");

            if (context.GetChild(0) == context.tipo() && context.GetChild(1) == context.ID() && context.GetChild(2) == context.novo_parametro())
            {
                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());
            }
            else if (context.GetChild(0) != context.EPSILON())
                Erros.Add("esperado : (parametro)");

            return base.VisitParametros(context);
        }

        public override object VisitNovo_parametro([NotNull] TokenParser.Novo_parametroContext context)
        {
            if (context is null)
                Erros.Add("nulo");

            if (context.GetChild(0) == context.COMMA() && context.GetChild(1) == context.tipo() && context.GetChild(2) == context.ID() && context.GetChild(3) == context.novo_parametro())
            {
                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());
                Program.Add(context.GetChild(3).GetText());
            }
            else if (context.GetChild(0) != context.EPSILON())
                Erros.Add("esperado : novo parametro");

            return base.VisitNovo_parametro(context);
        }

        public override object VisitPrincipal([NotNull] TokenParser.PrincipalContext context)
        {
            if (context is null)
                Erros.Add("nulo");


            if (context.GetChild(0) == context.MAIN() && context.GetChild(1) == context.OPEN_PARENTHESIS() && context.GetChild(2) == context.CLOSE_PARENTHESIS() && context.GetChild(3) == context.bloco())
            {
                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());
                Program.Add(context.GetChild(3).GetText());
            }


            return base.VisitPrincipal(context);
        }

        public override object VisitBloco([NotNull] TokenParser.BlocoContext context)
        {
            if (context is null)
                Erros.Add("nulo");

            if (context.GetChild(0) == context.OPEN_CURLYBRACKET() && context.GetChild(1) == context.dec_variaveis() && context.GetChild(2) == context.comandos() && context.GetChild(3) == context.CLOSE_CURLYBRACKET())
            {
                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());
                Program.Add(context.GetChild(3).GetText());
            }


            return base.VisitBloco(context);
        }

        public override object VisitDec_variaveis([NotNull] TokenParser.Dec_variaveisContext context)
        {
            if (context is null)
                Erros.Add("nulo");

            if (context.GetChild(0) == context.tipo() && context.GetChild(1) == context.ID() && context.GetChild(2) == context.novo_id() && context.GetChild(3) == context.SEMICOLON() && context.GetChild(4) == context.dec_variaveis())
            {
                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());
                Program.Add(context.GetChild(3).GetText());
                Program.Add(context.GetChild(4).GetText());
            }

            return base.VisitDec_variaveis(context);
        }

        public override object VisitNovo_id([NotNull] TokenParser.Novo_idContext context)
        {
            if (context is null)
                Erros.Add("nulo");

            if (context.GetChild(0) == context.COMMA() && context.GetChild(1) == context.ID() && context.GetChild(2) == context.novo_id())
            {
                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());
             
            }
            else if (context.GetChild(0) != context.EPSILON())
                Erros.Add("esperado : novo id");

            return base.VisitNovo_id(context);
        }


        public override object VisitComandos([NotNull] TokenParser.ComandosContext context)
        {
            if (context is null)
                Erros.Add("nulo");

            if (context.GetChild(0) == context.comando() && context.GetChild(1) == context.comandos())
            {
                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
            }
            else if (context.GetChild(0) != context.EPSILON())
                Erros.Add("esperado : comandos");

            return base.VisitComandos(context);
        }

        public override object VisitComando([NotNull] TokenParser.ComandoContext context)
        {
            if (context is null)
                Erros.Add("nulo");

            if (context.GetChild(0) == context.leitura() && context.GetChild(1) == context.escrita() && context.GetChild(2) == context.atribuicao() && context.GetChild(3) == context.funcao() && context.GetChild(4) == context.selecao() && context.GetChild(5) == context.enquanto() && context.GetChild(6) == context.retorno())
            {
                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());
                Program.Add(context.GetChild(3).GetText());
                Program.Add(context.GetChild(4).GetText());
                Program.Add(context.GetChild(5).GetText());
                Program.Add(context.GetChild(6).GetText());

            }
           
            return base.VisitComando(context);
        }

        public override object VisitLeitura([NotNull] TokenParser.LeituraContext context)
        {
            if (context is null)
                Erros.Add("nulo");

            if (context.GetChild(0) == context.SCANF() && context.GetChild(1) == context.OPEN_PARENTHESIS() && context.GetChild(2) == context.ID() && context.GetChild(3) == context.novo_id() && context.GetChild(4) == context.CLOSE_PARENTHESIS() && context.GetChild(5) == context.SEMICOLON())
            {
                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());
                Program.Add(context.GetChild(3).GetText());
                Program.Add(context.GetChild(4).GetText());
                Program.Add(context.GetChild(5).GetText());
              
            }

            return base.VisitLeitura(context);
        }

        public override object VisitEscrita([NotNull] TokenParser.EscritaContext context)
        {
            if (context is null)
                Erros.Add("nulo");

            if (context.GetChild(0) == context.PRINTLN() && context.GetChild(1) == context.OPEN_PARENTHESIS() && context.GetChild(2) == context.termo() && context.GetChild(3) == context.novo_termo() && context.GetChild(4) == context.CLOSE_PARENTHESIS() && context.GetChild(5) == context.SEMICOLON())
            {
                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());
                Program.Add(context.GetChild(3).GetText());
                Program.Add(context.GetChild(4).GetText());
                Program.Add(context.GetChild(5).GetText());
              
            }

            return base.VisitEscrita(context);
        }

        public override object VisitTermo([NotNull] TokenParser.TermoContext context)
        {
            if (context is null)
                Erros.Add("nulo");
            if (context.GetChild(0) == context.ID())
            {
                Program.Add(context.GetChild(0).GetText());
                
            }

            if(context.GetChild(0) == context.constante())
            {
                Program.Add(context.GetChild(0).GetText());
            }

            return base.VisitTermo(context);
        }

        public override object VisitNovo_termo([NotNull] TokenParser.Novo_termoContext context)
        {
            if (context is null)
                Erros.Add("nulo");

            if (context.GetChild(0) == context.COMMA() && context.GetChild(1) == context.termo() && context.GetChild(2) == context.novo_termo())
            {
                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());
            }
            else if (context.GetChild(0) != context.EPSILON())
                Erros.Add("esperado : novo termo");

            return base.VisitNovo_termo(context);
        }

        public override object VisitSelecao([NotNull] TokenParser.SelecaoContext context)
        {
            if (context is null)
                Erros.Add("nulo");

            if (context.GetChild(0) == context.IF() && context.GetChild(1) == context.OPEN_PARENTHESIS() && context.GetChild(2) == context.expressao() && context.GetChild(3) == context.CLOSE_PARENTHESIS() && context.GetChild(4) == context.bloco() && context.GetChild(5) == context.senao())
            {
                Program.Add(context.GetChild(0).GetText());
                Program.Add(context.GetChild(1).GetText());
                Program.Add(context.GetChild(2).GetText());
                Program.Add(context.GetChild(3).GetText());
                Program.Add(context.GetChild(4).GetText());
                Program.Add(context.GetChild(5).GetText());
            }

            return base.VisitSelecao(context);
        }
        #endregion
    }
}
