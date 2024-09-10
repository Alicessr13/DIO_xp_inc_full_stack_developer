//POO = paradgima de programação, quatro pilares: Abstração, Encapsulamento, Herança, Polimosfismo

//Principal conceito, classes e objestos, exemplo: classe: pessoa, objeto: bob

//Abstração = abstrair um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes

//Encapsulamento = proteger uma classe e definir limites para alteração de suas propriedades (ocultar comportamente e expor somente o necessário)
using ExemploPOO.models;

//criando objeto da classe
Pessoa p1 = new Pessoa();
p1.Nome = "Alice";
p1.Idade = 21;
p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123,1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();
