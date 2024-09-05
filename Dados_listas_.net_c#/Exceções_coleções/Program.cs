try
{

    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");
    //file = classe propria para ler arquivos
    //lendo o arquivo e retornando no array de string

    //exceção = quando o programa não tem saida, tava tentando fazer o que foi programado mas não conseguiu e não sabe o que fazer, encerra o programa

    //try catch = quando acontecer o erro não encerrar o programa ou tratar o erro

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

}
catch (Exception ex) //ex = variavel
{
    //ex é uma exceção, message retorna uma mensagem que descreve a exceção
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}