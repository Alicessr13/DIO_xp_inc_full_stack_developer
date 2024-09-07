using Propriedades.models;
using System.Globalization;

//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); //configurar todo o sistema para uma locaçização especifica

Pessoa p1 = new Pessoa(nome: "Alice", sobrenome: "Stephanie");

//p1.Nome = "Alice";
p1.Idade = 21;
//p1.Sobrenome = "Stephanie";
//p1.Apresentar();

Pessoa p2 = new Pessoa();
p2.Nome = "Eduardo";
p2.Sobrenome = "Neves Queiroz";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();


//formatando valores monetários
decimal valorMonetario = 1582.40m;

//quando coloca : significa que vai utilizar uma formatação especifica
// :c = valor monetario baseado em como está configurado a localização na maquina/pc
Console.WriteLine($"{valorMonetario:c}");

Console.WriteLine(valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-us")));
//formata para outra cultura/localização sem alterar o programa todo

Console.WriteLine(valorMonetario.ToString("C5")); // C2 e N2 personalizando o número de casas decimais

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("p")); //formata em porcentagem

int numero = 123456;
 
Console.WriteLine(numero.ToString("##-##-##")); //formatação personalizada

DateTime data = DateTime.Now; //pega a data e hora do computador

Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM-yyyy HH:mm")); //date formatado
//MM = mês, mm = minuto, hh = hora em 12 horas, HH = hora em 24 horas

Console.WriteLine(data.ToShortDateString()); //somente a data
Console.WriteLine(data.ToShortTimeString()); //somente a hora

string dataString = "2022-04-17 18:00";
DateTime data2 = DateTime.Parse("17-04-2022 18:00"); //converte um texto para o tipo dateTime

//conversão segura de dateTime:
bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data3); 
//recebe a string para converter, formato que ela está, cultura/localização que está (invariantculture = independente de uma cultura especifica),
//estilo do dateTime, parametro de saida
Console.WriteLine(data2);

if(sucesso){
    Console.WriteLine($"Conversão com sucesso {data3}");
}
else{
    Console.WriteLine($"{dataString} não é uma data valida");
}

//descontrutor
Pessoa p3 = new Pessoa("Alice", "Stephanie");

(string nome, string sobrenome) = p3;
//pega os valores e coloca em váriaveis (descontruindo em uma varíavel)
Console.WriteLine($"{nome} {sobrenome}");