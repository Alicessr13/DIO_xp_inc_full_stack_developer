//nuget = gerenciador de pacotes (conjunto de códigos uteis, possibilita compartilhamento e reuso do código)
//pacote = projeto que resolve um problema especifico

//nuget = nuget.org, site com pacotes (integração amazon, testes unitarios, integração azure, etc)
//referencia ao pacote nuget fica em csproj

//serialização = transformar objetos em um fluxo de bytes para seu armazenamento e transmissão
//tranforma o objeto em algum mais proximo do que deseja armazenar  exemplo: objeto pessoa => banco de dados, objeto pessoa => arquivo, transmitir dado
//ou seja pegar um objeto do programa tranformar para ser representado da mesma maneira em outro destino

//deserialização = processo inverso de serialização
//pega os dados de um arquivo faz o processo inverso para ele virar um objeto no programa e ser possivel armazenar

//json = formato de texto que segue a sintaxe do javascript, usado para transmitir dados

using Nuget_serializar_atributos.models;
using Newtonsoft.Json; //para usar o pacote

//os nomes do arquivo json precisam bater com o nome na classe no c#, exemplo id = id, 
//se for diferente precisa fazer igual exemplo classe vendas
 
DateTime dataAtual = DateTime.Now;
//tipo datetime só existe no c#, para serialização ele usa padrão ISO 8601 (maioria das linguagens trabalha com esse formato)

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); 
//SerializeObject = serializa em uma string json, Formatting.Indented = adiciona quebra de linha deixa identado
//quebra de linhas e espaços deixam o arquivo json mais pesado

Console.WriteLine(serializado);

File.WriteAllText("Arquivos/vendas.json", serializado); //cria o arquivo json e coloca os dados

//importar arquivo json
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
//analisar o arquivo validar o conteudo e criar a classe baseado nos dados que irá receber do arquivo
//deserializando para uma lista de venda que foi criada beaseada no arquivo
List<Venda> listaVendas2 = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach(Venda venda in listaVendas2){
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, "+
    $"Preço: {venda.Preco}, Data: {venda.DataVenda}");
}