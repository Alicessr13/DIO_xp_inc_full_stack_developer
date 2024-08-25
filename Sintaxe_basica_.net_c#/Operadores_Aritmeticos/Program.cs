using Operadores_Aritmeticos.Models;

Calculadora calc = new Calculadora();

calc.Somar(2,3);
calc.Subtrair(2,3);
calc.Multiplicar(10,2);
calc.Dividir(10,2);
calc.Potencia(3,3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);

int numeroIncremento = 10;

Console.WriteLine(numeroIncremento);

Console.WriteLine("Incrementando o 10");
numeroIncremento++; // numero = numero + 1

Console.WriteLine(numeroIncremento);

int numeroDecremento = 20;

Console.WriteLine(numeroDecremento);

Console.WriteLine("Decrementando o 20");
numeroDecremento--; //numero = numero - 1

Console.WriteLine(numeroDecremento);

