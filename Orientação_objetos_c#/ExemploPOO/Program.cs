//POO = paradgima de programação, quatro pilares: Abstração, Encapsulamento, Herança, Polimosfismo

//Principal conceito, classes e objestos, exemplo: classe: pessoa, objeto: bob

//Abstração = abstrair um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes exemplo classe pessoa

//Encapsulamento = proteger uma classe e definir limites para alteração de suas propriedades (ocultar comportamente e expor somente o necessário) exemplo classe contacorrente

//herança = reutilziação de atributos, métodos e comportamentos de uma classe em outras classes, exemplo classe aluno (herda de pessoa), professor também herda de pessoa
//pessoa pode ser uma classe pai e aluno e professora classes filhas, 
//herança multipla não existe no c# uma classe só pode ter uma herança exemplo: aluno não herda de pessoa e professor ao mesmo tempo

//polimorfismo = "muitas formas", podemos sobreescrever métodos das classes filhas para que se comportem diferente e ter sua propria implementação
using ExemploPOO.models;

//criando objeto da classe
Pessoa p1 = new Pessoa();
p1.Nome = "Alice";
p1.Idade = 21;
p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

//aluno herda nome, idade e apresentar de pessoa
Aluno a1 = new Aluno();
a1.Nome = "Malia";
a1.Idade = 7;
a1.Nota = 10;
a1.Apresentar();

Professor pf1 = new Professor();
pf1.Nome = "Graziella";
pf1.Idade = 38;
pf1.Salario = 1000;
pf1.Apresentar();
