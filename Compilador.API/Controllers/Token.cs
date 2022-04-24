using System;
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
            {87, "STRING"}
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
            this.token = valuesList[value];
            this.lexeme = lexeme;
            tokenID = value;
            if (value == 5)
                id = ++idcount;
            else 
                id = 0;
        }
        public override string ToString()
        {
            return "Lexeme : " + Lexeme + " | Token : " + _Token + GetID + "\n"; 
        }
    }
}
