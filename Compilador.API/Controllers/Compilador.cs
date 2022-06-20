using System.Collections.Generic;
using Compilador.API.Token;

namespace Compilador.API.Controllers
{
    public class Compilador
    {
        public string mensagem = "Token.Token: ";
        public void Lexico(string args)
        {
            List<Token.Token> tokens = new List<Token.Token>();

            string currentLexeme = "";
            int id = 0;
            char[] current = args.ToCharArray();

            for (int i = 0; i < current.Length; i++)
            {
                if (id == 0)
                {
                    if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (current[i] == ' ')
                        continue;
                    else if (current[i] == '\n')
                        continue;
                    else if (current[i] == '<')
                    {
                        currentLexeme += current[i];
                        id = 55;
                    }

                    else if (current[i] == '>')
                    {
                        currentLexeme += current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        currentLexeme += current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        currentLexeme += current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        currentLexeme += current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        currentLexeme += current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        currentLexeme += current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token.Token(67, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token.Token(68, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token.Token(69, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token.Token(70, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token.Token(71, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token.Token(72, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token.Token(73, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token.Token(74, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token.Token(75, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token.Token(76, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token.Token(77, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token.Token(79, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        id = 5;
                        currentLexeme += current[i];
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        id = 83;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == '"')
                    {
                        id = 87;
                        currentLexeme = "" + current[i];
                    }
                    else
                    {
                        tokens.Add(new Token.Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 5)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        id = 5;
                        currentLexeme += current[i];
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        id = 5;
                        currentLexeme += current[i];
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        id = 5;
                        currentLexeme += current[i];
                    }
                    else
                    {
                        tokens.Add(new Token.Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 55)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token.Token(55, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token.Token(55, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token.Token(55, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token.Token(59, currentLexeme + current[i]));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token.Token(55, currentLexeme));
                        tokens.Add(new Token.Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token.Token(55, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }

                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token.Token(55, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token.Token(55, currentLexeme));
                        currentLexeme = "" + current[i];
                    }
                    else
                    {
                        tokens.Add(new Token.Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 56)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token.Token(56, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token.Token(56, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token.Token(56, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token.Token(60, currentLexeme + current[i]));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token.Token(56, currentLexeme));
                        tokens.Add(new Token.Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token.Token(56, currentLexeme));
                        currentLexeme = "";
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token.Token(56, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token.Token(56, currentLexeme));
                        currentLexeme = "" + current[i];
                    }
                    else
                    {
                        tokens.Add(new Token.Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 57)
                {
                    if (current[i] == '=')
                    {
                        tokens.Add(new Token.Token(61, currentLexeme + current[i]));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token.Token(57, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token.Token(57, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token.Token(57, currentLexeme));
                        tokens.Add(new Token.Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token.Token(57, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token.Token(57, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token.Token(57, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token.Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 58)
                {
                    if (current[i] == '=')
                    {
                        tokens.Add(new Token.Token(62, currentLexeme + current[i]));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token.Token(58, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token.Token(58, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token.Token(58, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token.Token(58, currentLexeme));
                        tokens.Add(new Token.Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token.Token(58, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token.Token(58, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token.Token(58, currentLexeme));
                            id = 5;
                        currentLexeme = "" + current[i];
                    }
                    else
                    {
                        tokens.Add(new Token.Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 63)
                {
                    if (current[i] == '|')
                    {
                        tokens.Add(new Token.Token(64, currentLexeme + current[i]));
                        currentLexeme = "";
                        id = 0;
                    }
                    else
                    {
                        tokens.Add(new Token.Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 65)
                {
                    if (current[i] == '&')
                    {
                        tokens.Add(new Token.Token(66, currentLexeme + current[i]));
                        currentLexeme = "";
                        id = 0;
                    }
                    else
                    {
                        tokens.Add(new Token.Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 78)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        if (current[i] == 'i')
                            id = 1;
                        else if (current[i] == 'f')
                            id = 6;
                        else if (current[i] == 'c')
                            id = 13;
                        else if (current[i] == 'b')
                            id = 17;
                        else if (current[i] == 'e')
                            id = 24;
                        else if (current[i] == 'w')
                            id = 28;
                        else if (current[i] == 's')
                            id = 33;
                        else if (current[i] == 'm')
                            id = 38;
                        else if (current[i] == 'p')
                            id = 42;
                        else if (current[i] == 'r')
                            id = 49;
                        else
                            id = 5;
                        currentLexeme = "" + current[i];
                    }
                    else
                    {
                        tokens.Add(new Token.Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 83)
                {
                    if (current[i] == '.')
                    {
                        currentLexeme += current[i];
                        id = 84;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else
                    {
                        tokens.Add(new Token.Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 84)
                {
                    if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 85;
                    }
                    else
                    {
                        tokens.Add(new Token.Token(-1, currentLexeme));
                        id = 0;
                        currentLexeme = "";
                    }
                }
                else if (id == 85)
                {
                    if (char.IsNumber(current[i]))
                        currentLexeme += current[i];
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token.Token(id, currentLexeme));
                        tokens.Add(new Token.Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else
                    {
                        tokens.Add(new Token.Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 87)
                {
                    if (current[i] == '"')
                    {
                        currentLexeme += current[i];
                        tokens.Add(new Token.Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else currentLexeme += current[i];
                }
            }

            if (currentLexeme != "")
            {
                if (id == 87)
                    tokens.Add(new Token.Token(-1, currentLexeme));
                else
                    tokens.Add(new Token.Token(id, currentLexeme));
            }

            string resultado = "";
            foreach (Token.Token token in tokens)
            {
                resultado += token.ToString();
            }

            this.mensagem = resultado;
        }
    }
}
