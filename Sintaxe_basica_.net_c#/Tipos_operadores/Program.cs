// operador = é de atribuição

//para atribuir o valor precisa ser do mesmo tipo da variavel
int a = Convert.ToInt32("10"); //para converter pode ser utilizado a classe convert

int b = int.Parse("10");//para converter também pode ser utilizado o parse
//se eles não conseguirem converter gera erro no código exemplo: int.parse("10a");

//convert valor null = 0, parse valor null gera erro 

int c = a + b;

c += 5; //mesma coisa que c = c+5;
c -= 2;

Console.WriteLine(c);


//converter para string
int inteiro = 5;

string d = inteiro.ToString();

//conversão/cast implícito, ele não diz que está convertendo mas está, só é possivel quando o tipo e valor da variavel cabe na outra variavel
int e = 5;
double f = e;

Console.WriteLine(f);

//ordem de prioridade dos operadores: () depois expoente depois / * depois + -
double g = 4 / (2 + 2); //nesse exemplo faz o que está dentro do parenteses primeiro

Console.WriteLine(g);


//conversão segura
string h = "15-";

int i = 0;

//vai tentar converter para inteiro, mas ja espera o erro
int.TryParse(h, out i); //precisa informar o a ser convertido e a saída
//se converter corretamente coloca o valor resultante em i, se não converter não para o programa (metodo seguro de conversão)

Console.WriteLine(i);


//operador condicional (if else)
int quantidadeEmEstoque = 10;

int quantidadeCompra = 0;

bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra; //para ser true as duas condições precisam ser verdadeiras

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine("Quantidade compra: " + quantidadeCompra);
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

//if valida somente condições ou valor bool, se entrar na primeira condição não entra na segunda nem na ultima, se não entrar na primera vai para as proximas
if (quantidadeCompra <= 0)
{
    Console.WriteLine("Venda invalida");
}
else if (possivelVenda)
{//se essa condição for verdadeira executa esse código
    Console.WriteLine("Venda realizada");
}
else
{//se não executa esse código
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
}

//switch case

Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine(); //espera o usuário digitar, le o que o usuário digitar e espera o comando enter

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Não é um vogal");
        break;
}

//operador OR (pipe, ||)

bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada");
}
else
{
    Console.WriteLine("Entrada não liberada");
}