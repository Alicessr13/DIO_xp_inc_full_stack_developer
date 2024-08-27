//array, estrutura de dados (variavel) que armazena valores do mesmo tipo com tamanho fixo
//criando array:
//int[] array = new int[4], int[] array = new int[] {1,2,3,4}, string[] nomes = {"jan","fev"}

//array possui indice = posição de um terminado valor dentro do array, sempre começa com 0
//int elemento = array[0] (pegando o valor na posição 0), array[0] = 42 (alterando o valor da posição 0)

int[] arrayInteiros = new int[3]; //array de inteiro com 3 posições (0,1,2) e sempre vai ter esse valor definido ate o final do program
//para alterar o tamanho do array com resiza ele cria um novo array com a nova capacidade e vai copiar os valores do antigo para o novo (ou seja cria uma cópia)

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
//se tentar acessar uma posição que não existe gera erro

//classe array para trabalhar com arrays, com o resize pode alterar o tamanho do array
//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); 
//precisa da referencia do endereço da memoria do array com o ref e depois coloca o novo valor

Console.WriteLine("Percorrendo array com for");
for (int i = 0; i < arrayInteiros.Length; i++)
{//i começa em zero e vai até 2, o tamanho do array
    Console.WriteLine($"Posição nº {i} - {arrayInteiros[i]}");
}

//foreach

Console.WriteLine("Percorrendo array com foreach");
//variavel do mesmo tipo do array
foreach (int valor in arrayInteiros)//para cada elemento no array atribui o valor para a variavel
{
    //não utiliza contador para acessar os valores
    Console.WriteLine(valor);
}

//copiar valores de um array para outro

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);
//com a classe array tem o copy, informa onde estão os elementos(arrayInteiros), para onde vai copiar(arrayInteirosDobrado), 
//e a quantidade que quer copiar (arrayInteiros.Length = tudo)

//lista = coleção de mesmo tipo mas não precisa passar a capacidade na criação
//internamente uma lista trabalha com array, por isso ela possui capacidade/capacity
//na lista não precisa se preocupar com a capacidade ela ja gerencia automaticamente

List<string> listaString = new List<string>();

//add = adiciona elemento, addrange = adiciona mais de um elemento
listaString.Add("SP");
listaString.Add("SC");
listaString.Add("BH");

Console.WriteLine("Percorrendo lista com for");

for(int contador = 0; contador <listaString.Count; contador++){ //count assim como lenght também pega a quantidade de elementos
    Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
}

Console.WriteLine("Percorrendo lista com foreach");
int contadorForeach = 0;
foreach(string cidade in listaString){
    Console.WriteLine($"Posição Nº {contadorForeach} - {cidade}");
    contadorForeach++;
}