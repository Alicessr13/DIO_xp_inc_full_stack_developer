//POO = paradgima de programação, quatro pilares: Abstração, Encapsulamento, Herança, Polimosfismo

//Principal conceito, classes e objestos, exemplo: classe: pessoa, objeto: bob

//Abstração = abstrair um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes exemplo classe pessoa

//Encapsulamento = proteger uma classe e definir limites para alteração de suas propriedades (ocultar comportamente e expor somente o necessário) exemplo classe contacorrente

//herança = reutilziação de atributos, métodos e comportamentos de uma classe em outras classes, exemplo classe aluno (herda de pessoa), professor também herda de pessoa
//pessoa pode ser uma classe pai e aluno e professora classes filhas, 
//herança multipla não existe no c# uma classe só pode ter uma herança exemplo: aluno não herda de pessoa e professor ao mesmo tempo, somente de pessoa, 
//mas pessoa pode ser herdado por aluno e professor

//polimorfismo = "muitas formas", podemos sobreescrever métodos das classes filhas para que se comportem diferente e ter sua propria implementação

//classe abstrata = classe com o objetivo de ser somente um modelo para ser herdado, portanto não pode ser instanciada exemplo classe conta e classe corrente

//classe selada = classe com o objetivo de impedir que outras classes façam herança dela, ou seja, nenhuma pode ser sua derivada, exemplo classe professor

//classe system.object é a mãe de todas as classes na hierarquia do .net
//todas as classes derivam direta ou indiretamente da classe object, tem como objetivo prover serviços de baixo nível para as classes filhas

//Uma interface é um contrato que pode ser implementado por uma classe, como se fosse uma classe abstrata pode ter métodos abstratos e não pode ser instanciada
//todo o que precisa que seja implementado coloca na interface e quem implementar a interface vai ser obrigado a implementar os métodos dela
//uma classe pode implementar mais de uma interface

using ExemploPOO.Interfaces;
using ExemploPOO.models;


//criando objeto da classe
Pessoa p1 = new Pessoa("Alice");
//p1.Nome = "Alice";
p1.Idade = 21;
p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

//aluno herda nome, idade e apresentar de pessoa
Aluno a1 = new Aluno("Malia");
//a1.Nome = "Malia";
a1.Idade = 7;
a1.Nota = 10;
a1.Apresentar();

Professor pf1 = new Professor();
pf1.Nome = "Graziella";
pf1.Idade = 38;
pf1.Salario = 1000;
pf1.Apresentar();

Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();

Computador comp = new Computador();
comp.ToString();

//interface recebe new calculadora, funciona porque calculadora implementa a interface
ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3,9));