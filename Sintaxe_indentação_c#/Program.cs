// See https://aka.ms/new-console-template for more information

//"dotnet new console" no terminal cria um novo projeto .net na pasta
//ctrl shift ' abre um novo terminal ctrl ' abre o terminal que ja estava sendo utilizado
//"dotnet run" executa o projeto
//"dotnet build" compila o projeto

// .cs = classe, onde realiza o código, classe = conceito representado do mundo real(possui atributos e métodos)

//todo nome de classe deve começar com maisculo, exemplo: PessoaFísica

//Promgram.cs é o ponto de entrada do programa, começa a ler do program

using Sintaxe_indentação_c_.models; //atravez do namespace irá reconhecer a classe pessoa

Pessoa pessoa = new Pessoa();//instanciar a classe, p = variavel

pessoa.Nome = "Alice"; //representa o set por estar passando um valor para nome
pessoa.Idade = 21;
pessoa.Apresentar();