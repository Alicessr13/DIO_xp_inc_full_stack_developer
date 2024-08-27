//array, estrutura de dados (variavel) que armazena valores do mesmo tipo com tamanho fixo
//criando array:
//int[] array = new int[4], int[] array = new int[] {1,2,3,4}, string[] nomes = {"jan","fev"}

//array possui indice = posição de um terminado valor dentro do array, sempre começa com 0
//int elemento = array[0] (pegando o valor na posição 0), array[0] = 42 (alterando o valor da posição 0)

int[] arrayInteiros = new int[3]; //array de inteiro com 3 posições (0,1,2)

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
//se tentar acessar uma posição que não existe gera erro

for (int i = 0; i < arrayInteiros.Length; i++)
{//i começa em zero e vai até 2, o tamanho do array
    Console.WriteLine($"Posição nº {i} - {arrayInteiros[i]}");
}

//foreach

//variavel do mesmo tipo do array
foreach (int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}