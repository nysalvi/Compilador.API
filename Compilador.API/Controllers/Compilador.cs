using System.Collections.Generic;
namespace Compilador.API.Controllers
{
    public class Compilador
    {
        public string mensagem = "Token: ";
        public void Lexico(string args)
        {
            List<Token> tokens = new List<Token>();

            string currentLexeme = "";
            int id = 0;
            char[] current = args.ToCharArray();

            for (int i = 0; i < current.Length; i++)
            {
                if (id == 0)
                {
                    if (current[i] == 'i')
                    {
                        id = 1;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == 'f')
                    {
                        id = 6;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == 'c')
                    {
                        id = 13;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == 'b')
                    {
                        id = 17;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == 'e')
                    {
                        id = 24;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == 'w')
                    {
                        id = 28;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == 's')
                    {
                        id = 33;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == 'm')
                    {
                        id = 38;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == 'p')
                    {
                        id = 42;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == 'r')
                    {
                        id = 49;
                        currentLexeme += current[i];
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
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(67, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(68, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(69, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(70, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(71, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(72, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(73, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(74, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(75, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(76, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(77, current[i].ToString()));
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(79, current[i].ToString()));
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
                    else if (char.IsLetter(current[i]))
                    {
                        id = 5;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == '"')
                    {
                        id = 87;
                        currentLexeme = "" + current[i];
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 1)
                {
                    if (current[i] == 'f')
                    {
                        id = 4;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == 'n')
                    {
                        id = 2;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 2)
                {
                    if (current[i] == 't')
                    {
                        id = 3;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 3)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 4)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 5)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 6)
                {
                    if (current[i] == 'l')
                    {
                        currentLexeme += current[i];
                        id = 7;
                    }
                    else if (current[i] == 'o')
                    {
                        currentLexeme += current[i];
                        id = 11;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 7)
                {
                    if (current[i] == 'o')
                    {
                        currentLexeme += current[i];
                        id = 8;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 8)
                {
                    if (current[i] == 'a')
                    {
                        id = 9;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 9)
                {
                    if (current[i] == 't')
                    {
                        id = 10;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75,
"+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 10)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75,
"+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 11)
                {
                    if (current[i] == 'r')
                    {
                        currentLexeme += current[i];
                        id = 12;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75,
"+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 12)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 13)
                {
                    if (current[i] == 'h')
                    {
                        currentLexeme += current[i];
                        id = 14;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 14)
                {
                    if (current[i] == 'a')
                    {
                        currentLexeme += current[i];
                        id = 15;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 15)
                {
                    if (current[i] == 'r')
                    {
                        currentLexeme += current[i];
                        id = 16;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 16)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 17)
                {
                    if (current[i] == 'o')
                    {
                        id = 18;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 18)
                {
                    if (current[i] == 'o')
                    {
                        id = 19;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5,
currentLexeme)); tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5,
currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 19)
                {
                    if (current[i] == 'l')
                    {
                        id = 20;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 20)
                {
                    if (current[i] == 'e')
                    {
                        id = 21;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 21)
                {
                    if (current[i] == 'a')
                    {
                        id = 22;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 22)
                {
                    if (current[i] == 'n')
                    {
                        id = 23;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 23)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 24)
                {
                    if (current[i] == 'l')
                    {
                        currentLexeme += current[i];
                        id = 25;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 25)
                {
                    if (current[i] == 's')
                    {
                        currentLexeme += current[i];
                        id = 26;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 26)
                {
                    if (current[i] == 'e')
                    {
                        currentLexeme += current[i];
                        id = 27;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 27)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 28)
                {
                    if (current[i] == 'h')
                    {
                        currentLexeme += current[i];
                        id = 29;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 29)
                {
                    if (current[i] == 'i')
                    {
                        id = 30;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 30)
                {
                    if (current[i] == 'l')
                    {
                        currentLexeme += current[i];
                        id = 31;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 31)
                {
                    if (current[i] == 'e')
                    {
                        currentLexeme += current[i];
                        id = 32;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 32)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 33)
                {
                    if (current[i] == 'c')
                    {
                        currentLexeme += current[i];
                        id = 34;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 34)
                {
                    if (current[i] == 'a')
                    {
                        id = 35;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 35)
                {
                    if (current[i] == 'n')
                    {
                        id = 36;
                        currentLexeme += current[i];
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 36)
                {
                    if (current[i] == 'f')
                    {
                        currentLexeme += current[i];
                        id = 37;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 37)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 38)
                {
                    if (current[i] == 'a')
                    {
                        currentLexeme += current[i];
                        id = 39;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 39)
                {
                    if (current[i] == 'i')
                    {
                        currentLexeme += current[i];
                        id = 40;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 40)
                {
                    if (current[i] == 'n')
                    {
                        currentLexeme += current[i];
                        id = 41;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 41)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 42)
                {
                    if (current[i] == 'r')
                    {
                        currentLexeme += current[i];
                        id = 43;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 43)
                {
                    if (current[i] == 'i')
                    {
                        currentLexeme += current[i];
                        id = 44;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 44)
                {
                    if (current[i] == 'n')
                    {
                        currentLexeme += current[i];
                        id = 45;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 45)
                {
                    if (current[i] == 't')
                    {
                        currentLexeme += current[i];
                        id = 46;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 46)
                {
                    if (current[i] == 'l')
                    {
                        currentLexeme += current[i];
                        id = 47;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 47)
                {
                    if (current[i] == 'n')
                    {
                        id = 48;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 48)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 49)
                {
                    if (current[i] == 'e')
                    {
                        currentLexeme += current[i];
                        id = 50;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 50)
                {
                    if (current[i] == 't')
                    {
                        currentLexeme += current[i];
                        id = 51;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 51)
                {
                    if (current[i] == 'u')
                    {
                        currentLexeme += current[i];
                        id = 52;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 52)
                {
                    if (current[i] == 'r')
                    {
                        currentLexeme += current[i];
                        id = 53;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 53)
                {
                    if (current[i] == 'n')
                    {
                        currentLexeme += current[i];
                        id = 54;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 65;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(5, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 54)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 55)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(55, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(55, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(55, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        currentLexeme += current[i];
                        id = 59;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(55, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(55, currentLexeme));
                        currentLexeme = "";
                        id = 5;
                    }

                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(55, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(55, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 56)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(56, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(56, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(56, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        currentLexeme += current[i];
                        id = 60;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(56, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(56, currentLexeme));
                        currentLexeme = "";
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(56, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(56, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 57)
                {
                    if (current[i] == '=')
                    {
                        currentLexeme += current[i];
                        id = 61;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(57, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(57, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(57, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(57, currentLexeme));

                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(57, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(57, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 58)
                {
                    if (current[i] == '=')
                    {
                        currentLexeme += current[i];
                        id = 62;
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(58, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(58, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(58, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(58, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(58, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(58, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(58, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 59)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 60)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 61)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 62)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 63)
                {
                    if (current[i] == '|')
                    {
                        currentLexeme += current[i];
                        id = 64;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 64)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 65)
                {
                    if (current[i] == '&')
                    {
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 66)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 67)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 67;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 68;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 69;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 70;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 71;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 72;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 68)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 68;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 69;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 70;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 71;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 72;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 73;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 74;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 75;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 76;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 77;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 79;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 69)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 70)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 71)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 72)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 73)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 74)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 75)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 76)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 77)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 78)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 79)
                {
                    if (current[i] == '/')
                    {
                        id = 80;
                        tokens.Add(new Token(id, "%"));
                        currentLexeme = "";
                    }
                    else if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 83;
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        tokens.Add(new Token(id, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }
                }
                else if (id == 80)
                {
                    if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else
                    {
                        currentLexeme += current[i];
                    }
                }
                else if (id == 82)
                {
                    if (current[i] == ' ')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
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
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                        id = 5;
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
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
                        tokens.Add(new Token(-1, currentLexeme));
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
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '\n')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '"')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 87;
                    }
                    else if (current[i] == '<')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 55;
                    }
                    else if (current[i] == '>')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 56;
                    }
                    else if (current[i] == '!')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 57;
                    }
                    else if (current[i] == '=')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 58;
                    }
                    else if (current[i] == '|')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 63;
                    }
                    else if (current[i] == '/')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 78;
                    }
                    else if (current[i] == '&')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "" + current[i];
                        id = 66;
                    }
                    else if (current[i] == '(')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(67, "("));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ')')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(68, ")"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '[')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(69, "["));
                        currentLexeme = "";
                        id = 0;

                    }
                    else if (current[i] == ']')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(70, "]"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '{')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(71, "{"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '}')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(72, "}"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ',')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(73, ","));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == ';')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(74, ";"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '+')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(75, "+"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '-')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(76, "-"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '*')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(77, "*"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '%')
                    {
                        tokens.Add(new Token(id, currentLexeme));
                        tokens.Add(new Token(79, "%"));
                        currentLexeme = "";
                        id = 0;
                    }
                    else if (current[i] == '_')
                    {
                        currentLexeme += current[i];
                    }
                    else if (char.IsNumber(current[i]))
                    {
                        currentLexeme += current[i];
                    }
                    else if (char.IsLetter(current[i]))
                    {
                        currentLexeme += current[i];
                    }
                    else
                    {
                        tokens.Add(new Token(-1, currentLexeme));
                        break;
                    }

                }
                else if (id == 87)
                {
                    if (current[i] == '"')
                    {
                        currentLexeme += current[i];
                        tokens.Add(new Token(id, currentLexeme));
                        currentLexeme = "";
                        id = 0;
                    }
                    else currentLexeme += current[i];
                }
            }

            if (currentLexeme != "")
            {
                if (id == 87)
                    tokens.Add(new Token(-1, currentLexeme));
                else
                    tokens.Add(new Token(id, currentLexeme));
            }

            string resultado = "";
            foreach (Token token in tokens)
            {
                resultado += token.ToString();
            }

            this.mensagem = resultado;
            /* for (int i = 0; i < _tokens.Count; i++)
            {             
                Console.WriteLine(_tokens[i].ToString());
            }*/

        }
    }
}
