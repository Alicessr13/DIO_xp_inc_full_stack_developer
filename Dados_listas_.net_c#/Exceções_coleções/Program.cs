using Exceções_coleções.models;

//try catch precisa ser usado quando necessário pois pode afetar a performance, só se usa quando não tem controle do dado 
//(coisas simples como dado vazio não compensa usar o try catch)
try //tente fazer algo (dentro das chaves) com cautela porque pode acontecer um erro
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
    //file = classe propria para ler arquivos
    //lendo o arquivo e retornando no array de string

    //exceção = quando o programa não tem saida, tava tentando fazer o que foi programado mas não conseguiu e não sabe o que fazer, encerra o programa

    //try catch = quando acontecer o erro não encerrar o programa ou tratar o erro (sem o try catch o programa para)

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch (Exception ex) //pegar, pega a exceção e faz algo
{
    //no catch pode especificar a exceção e coloca uma variavel para receber a exceção
    //ex é uma exceção, message retorna uma mensagem que descreve a exceção

    //quando ocorrer uma exceção executa o console.writeline
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");

    //Exception é uma exceção genérica, mas podem ser tratadas exceções com base no que ocorreu
    //FileNotFoundException exceção especifica com base em algo que ocorreu
    //pode ter varias exceções, mas só cair em uma exceção por vez
}
finally
{ //finalmente/então faça executa o código sempre ao final da execução independente de acontecer uma exceção ou não
    Console.WriteLine("Chegou até aqui");
}


new ExemploExcecao().Metodo1();

//coleções fila, primeiro a entrar e o primeiro a sair (fifo)
//assim como array de somente 1 tipo

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);//adiciona um elemento ao fim da fila
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
//forma a fila sendo o 2 o elemento inicial

foreach (int item in fila)
{
    Console.WriteLine(item);
}

//fila.Dequeue(); = remove sempre o primeiro elemento

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);
}


//coleções pilha, ultimo que entrou e o primeiro a sair (LIFO)
Stack<int> pilha = new Stack<int>();

pilha.Push(5); //adiciona um elemento ao topo da pilha (inverso da fila)
pilha.Push(7);
pilha.Push(9);
pilha.Push(11);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

//pilha.Pop(); = remove sempre o elemento do topo da pilha
Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");

pilha.Push(20);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

//coleção dictionary = coleção de chave-valor para valores unicos sem ordem especifica
Dictionary<string, string> estados = new Dictionary<string, string>();
//precisa passar o tipo da chave e o dado
//garante que os elementos são unicos com base na chave, se a chave se repetir gera um exceção ou seja precisa ser unico (o dado pode repetir)

estados.Add("SP", "São Paulo");
estados.Add("SC", "Santa Catarina");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach (KeyValuePair<string, string> item in estados)//keyvaluepar para representar, pode usar var que ele vai reconhecer o tipo
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("------------------------");
estados.Remove("BA"); //removendo elementos

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("------------------------");
//só da para alterar o valor do dado, da chave não
estados["SP"] = "São Paulo - valor alterado";

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "sc";
Console.WriteLine($"Verificando o elemento {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existente. É seguro adicionar a chave: {chave}");
}

Console.WriteLine(estados["MG"]);