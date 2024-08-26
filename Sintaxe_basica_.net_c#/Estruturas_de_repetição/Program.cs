//estrutura for
int numero = 2;

for (int contador = 0; contador <= 2; contador++) //repete ate a condição ser falsa 
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}

//estrutura while

int numero2 = 5;
int contador2 = 0;

while (contador2 <= 10)
{ //repete até a condição ser falsa
    Console.WriteLine($"{numero2} x {contador2} = {numero2 * contador2}");
    contador2++;

    if (contador2 == 2)
    {
        break; //para a execução do programa mesmo que a condição seja verdadeira, funciona também com for
    }
}

//do while, diferente do while a condição é executada no final do código, ou seja ele sempre vai executar na primeira vez indenpende da condição

int soma = 0, numero3 = 0;

do
{
    Console.WriteLine("Digite um número (0 para parar)");
    numero3 = Convert.ToInt32(Console.ReadLine()); //read line recebe em string, por isso precisa converter para int

    soma += numero3;

} while (numero3 != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}");

//menu interativo
string opcao;
bool exibirMenu = true;

while (exibirMenu) // while(true) = looping infinito só vai para quando digitar 4
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente ");
    Console.WriteLine("2 - Buscar cliente ");
    Console.WriteLine("3 - Apagar cliente ");
    Console.WriteLine("4 - Encerrar ");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            //Environment.Exit(0); //encerra o programa, quando executar essa opção não executa mais nada no código
            exibirMenu = false;
            break;

        default: //se não cair em nenhuma opção
            Console.WriteLine("Opção invalida");
            break;
    }
}

Console.WriteLine("O programa se encerrou");