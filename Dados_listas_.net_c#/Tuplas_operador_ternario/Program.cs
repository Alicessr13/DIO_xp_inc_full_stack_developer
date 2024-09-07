//tupla agrupa vários elementos em uma estrutura de dados leve, diferentes tipos
//4 valores de diferentes tipos
using Tuplas_operador_ternario.models;

(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Alice", "Stephanie", 1.53M);
//tupla = variavel, ao passar os dados precisa respeitar de declaração do tipo do dado

Console.WriteLine($"ID: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Item4}");

ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Alice", "Stephanie", 1.53M); //desvantagen não pode nomear os tipos

var outroExemploTuplaCreate = Tuple.Create(1, "Alice", "Stephanie", 1.53M); //desvantagen não pode nomear os tipos e não passa os tipos

LeituraArquivo arquivo = new LeituraArquivo();

//no var não precisa passar o tipo ele identifica o tipo e assume, variaveis = sucesso, linhasArquivos, quantidadeLinhas
//var (sucesso, linhasArquivos, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
//se der erro sucesso vira false

var (sucesso, linhasArquivos, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
//com _ ele descarta a informação que receber (retorna a informação mas não usa)

if (sucesso)
{
    //Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
    foreach (string linha in linhasArquivos)
    {
        Console.WriteLine(linha);
    }
}
else
{ 
    Console.WriteLine("Não foi possível ler o arquivo");
}


//operador if ternário;
int numero = 20;

bool ehPar = false;

ehPar = numero % 2 == 0; //se o resta da divisão por 2 for zero é verdadeiro/true

Console.WriteLine($"O número {numero} é "+ (ehPar ? "par" : "ímpar")); 
//ehpar e verdadeiro ? se sim "par" se não : "ímpar"