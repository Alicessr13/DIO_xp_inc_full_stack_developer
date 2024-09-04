using Propriedades.models;

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