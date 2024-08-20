// operador = é de atribuição

//para atribuir o valor precisa ser do mesmo tipo da variavel
int a = Convert.ToInt32("10"); //para converter pode ser utilizado a classe convert

int b = int.Parse("10");//para converter também pode ser utilizado o parse
//se eles não conseguirem converter gera erro no código exemplo int.parse("10a");

int c = a + b;

c += 5; //mesma coisa que c = c+5;
c -= 2;

Console.WriteLine(c);


