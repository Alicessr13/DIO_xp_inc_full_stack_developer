﻿// See https://aka.ms/new-console-template for more information

//"dotnet new console" no terminal cria um novo projeto .net na pasta
//ctrl shift ' abre um novo terminal ctrl ' abre o terminal que ja estava sendo utilizado
//"dotnet run" executa o projeto
//"dotnet build" compila o projeto

// .cs = classe, onde realiza o código, classe = conceito representado do mundo real(possui atributos e métodos)

//Promgram.cs é o ponto de entrada do programa, começa a ler do program

using Sintaxe_indentação_c_.models; //atravez do namespace irá reconhecer a classe pessoa

Pessoa pessoa = new Pessoa();//instanciar a classe, p = variavel
//nome da variaveis camelCase (sem caracteres especiais, somente _)

pessoa.Nome = "Alice"; //representa o set por estar passando um valor para nome
pessoa.Idade = 21;
pessoa.Apresentar();

//Tipos de dados mais utilizados: string, object, bool, decimal(valores monetários, sempre trabalha com 2 casas decimais ou seja mais preciso), 
//double, int
//variavel = valor alocado na memoria para ser utilizado no programa
string apresentacao = "Ola, seja bem vindo";
int quantidade = 1;
double altura = 1.50; //cases decimais separadas por .
decimal preco = 1.80m; //precisa colocar M ao passar diretamente o valor
bool condicao = true;
DateTime dataAtual = DateTime.Now.AddDays(5); //now pega o horario da maquina, add adiciona a data 

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura);
Console.WriteLine("Valor da variável preço: " + preco);
Console.WriteLine("Valor da variável condição: " + condicao);
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));//alterar o formato da data
