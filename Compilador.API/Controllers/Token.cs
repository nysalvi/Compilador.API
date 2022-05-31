using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.API.Controllers
{
    public class Token
    {
        private static readonly Dictionary<int, string> valuesList = new Dictionary<int, string>()
        {
            {-1, "ERROR"},
            {3, "INTEGER"},
            {4, "IF"},
            {5, "ID"},
            {10, "FLOAT"},
            {12, "FOR"},
            {16, "CHAR"},
            {23, "BOOLEAN"},
            {27, "ELSE"},
            {32, "WHILE"},
            {37, "SCANF"},
            {41, "MAIN"},
            {42, "VOID" },
            {48, "PRINTLN"},
            {54, "RETURN"},
            {55, "<"},
            {56, ">"},
            {57, "!"},
            {58, "="},
            {59, "<="},
            {60, ">="},
            {61, "!="},
            {62, "=="},
            {64, "||"},
            {65, "&"},
            {66, "&&"},
            {67, "("},
            {68, ")"},
            {69, "["},
            {70, "]"},
            {71, "{"},
            {72, "}"},
            {73, ","},
            {74, ";"},
            {75, "+"},
            {76, "-"},
            {77, "*"},
            {79, "%"},
            {80, "COMMENT"},
            {83, "NUM_INT"},
            {85, "NUM_DEC" },
            {87, "TEXT"}
        };
        private static int idcount = 0;

        private string lexeme;
        private string token;

        private int tokenID;
        private int id;
        public string Lexeme => lexeme;
        public string _Token => token;
        public int TokenID => tokenID;
        public string GetID { get => TokenID == 5 ? " | ID : " + id : ""; }

        public Token(int value, string lexeme)
        {
            if (value == 5)
            {
                ArrayList array = ValidID(lexeme);
                    
                this.token = valuesList[(int)array[0]];
                this.lexeme = array[1].ToString();

            }
            else
            {
                this.token = valuesList[value];
                this.lexeme = lexeme;
            }
            tokenID = value;
            if (value == 5)
                id = ++idcount;
            else 
                id = 0;
        }
        private ArrayList ValidID(string lexeme)
        {
            if (lexeme == "int")
                return new ArrayList{3, "int"};

            if (lexeme == "if")
                return new ArrayList {4, "if"};

            if (lexeme == "void")
                return new ArrayList { 42, "void" };

            if (lexeme == "else")
                return new ArrayList { 27, "else" };

            if (lexeme == "scanf")
                return new ArrayList { 37, "scanf" };

            if (lexeme == "for")
                return new ArrayList { 12,"for" };

            if (lexeme == "char")
                return new ArrayList { 16, "char" };

            if (lexeme == "boolean")
                return new ArrayList { 23, "boolean"};

            if (lexeme == "main")
                return new ArrayList { 41, "main" };

            if (lexeme == "while")
                return new ArrayList { 32, "while" };

            if (lexeme == "println")
                return new ArrayList { 48, "println" };

            if (lexeme == "return")
                return new ArrayList { 54, "return" };

            if (lexeme == "float")
                return new ArrayList { 10,"float"};

            return new ArrayList { 5, "id"};
        } 
        public override string ToString()
        {
            return "Lexeme : " + Lexeme + " | Token : " + _Token + GetID + "\n"; 
        }
    }
}
