grammar Token;
	
/* 
 * Parser Rules
 */
	programa  :	funcoes principal;
	funcoes : dec_funcao funcoes | EPSILON;
	dec_funcao : tipo_retorno ID OPEN_PARENTHESIS parametros CLOSE_PARENTHESIS bloco;
	tipo_retorno : tipo | VOID;
	tipo : tipo_base dimensao;
	tipo_base : CHAR | FLOAT | INT | BOOLEAN;
	dimensao : OPEN_BRACKET INTEGER CLOSE_BRACKET dimensao | EPSILON;
	parametros : tipo ID novo_parametro | EPSILON;
	novo_parametro : COMMA tipo ID novo_parametro | EPSILON;
	principal : MAIN OPEN_PARENTHESIS CLOSE_PARENTHESIS bloco;
	bloco : OPEN_CURLYBRACKET dec_variaveis comandos CLOSE_CURLYBRACKET;
	dec_variaveis : tipo ID novo_id SEMICOLON dec_variaveis | EPSILON;
	novo_id : COMMA ID novo_id | EPSILON;
	comandos : comando comandos | EPSILON;
	comando : leitura | escrita | atribuicao | funcao | selecao | enquanto | retorno;
	leitura : SCANF OPEN_PARENTHESIS ID novo_id CLOSE_PARENTHESIS SEMICOLON;
	escrita : PRINTLN OPEN_PARENTHESIS termo novo_termo CLOSE_PARENTHESIS SEMICOLON;
	termo : ID | constante;
	novo_termo : COMMA termo novo_termo | EPSILON;
	selecao : IF OPEN_PARENTHESIS expressao CLOSE_PARENTHESIS bloco senao;
	senao : ELSE bloco | EPSILON;
	enquanto : WHILE OPEN_PARENTHESIS expressao CLOSE_PARENTHESIS bloco;
	atribuicao : ID ATTRIBUTION complemento;
	complemento : expressao SEMICOLON | funcao SEMICOLON;
	funcao : FUNC ID OPEN_PARENTHESIS argumentos CLOSE_PARENTHESIS;
	argumentos : expressao novo_argumento | EPSILON;
	novo_argumento : COMMA expressao novo_argumento | EPSILON;
	retorno : RETURN expressao SEMICOLON | EPSILON;
	expressao : expr_ou;
	expr_ou : expr_e expr_ou2;
	expr_ou2 : OR expr_e expr_ou2 | EPSILON;
	expr_e : expr_relacional expr_e2;
	expr_e2 : AND expr_relacional expr_e2 | EPSILON;
	expr_relacional : expr_aditiva expr_relacional2;
	expr_relacional2 : COMP expr_aditiva expr_relacional2 | EPSILON;
	expr_aditiva : expr_multiplicativa expr_aditiva2;
	expr_aditiva2 : op_aditivo expr_multiplicativa expr_aditiva2 | EPSILON;
	op_aditivo : PLUS | MINUS;
	expr_multiplicativa : fator expr_multiplicativa2;
	expr_multiplicativa2 : op_multiplicativo fator expr_multiplicativa2 | EPSILON;
	op_multiplicativo : TIMES | DIV | MOD;
	fator : sinal ID vetor | constante | NOT fator | OPEN_PARENTHESIS expressao CLOSE_PARENTHESIS;
	vetor : OPEN_BRACKET expr_aditiva CLOSE_BRACKET | EPSILON;
	constante : sinal INTEGER | sinal DECIMAL | TEXT;
	sinal : PLUS | MINUS | EPSILON;
	
/* 
 * Lexer Rules
 */ 
	
	WHITESPACE : (\t | \n | \r)+ -> skip;
	EPSILON	: ;
	OPEN_PARENTHESIS : '('; 
	CLOSE_PARENTHESIS :	')'; 
	OPEN_BRACKET : '[';
	CLOSE_BRACKET :	']'; 
	OPEN_CURLYBRACKET :	'{';
	CLOSE_CURLYBRACKET : '}'; 
	COMMA :	',';
	SEMICOLON :	';';
	
	PLUS : '+';
	MINUS :	'-';
	TIMES :	'*';
	DIV	: '/';
	MOD	: '%'; 
	
	NOT	: '!';
	ATTRIBUTION	:	'=';
	LOWER : '<'; 
	LOWER_EQUAL : '<=';
	BIGGER	: '>';
	BIGGER_EQUAL :	'>=';
	DIFFERENT : '!=';
	EQUALS	: '==';
	
	OR : '||';
	AND	: '&&';
	
	FUNC : 'func';
	COMP : LOWER | LOWER_EQUAL | BIGGER | BIGGER_EQUAL | DIFFERENT | EQUALS ;
	
	
	NEWLINE : ('\r'? '\n' | '\r')+ ;
	COMMENT	: '//' .*? NEWLINE;
	TEXT	: '"' .*? '"';
	
	IF : 'if';
	INT	: 'int';
	FOR	: 'for';
	CHAR : 'char';
	ELSE : 'else';
	MAIN : 'main';
	VOID : 'void';
	FLOAT :	'float';
	SCANF: 'scanf';
	WHILE: 'while';
	BOOLEAN : 'boolean';
	PRINTLN : 'println';
	RETURN : 'return';
	
	BOOL : 'true' | 'false';
	LETTER	: [a-z] | [A-Z] | '_';
	INTEGER : [0-9]+;
	DECIMAL : [0-9]+'.'[0-9]+;
	
	ID : LETTER+ INTEGER* LETTER*;