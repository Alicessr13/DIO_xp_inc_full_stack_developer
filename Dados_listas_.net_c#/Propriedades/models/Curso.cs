using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades.models
{
    public class Curso
    {
        public string Nome { get; set; }

        //coleção do tipo pessoa
        public List<Pessoa> Alunos { get; set; }

        //void = sem retorno, adicionar aluno recebe o parametro/argumento aluno do tipo pessoa, alunos.add aciona o aluno na lista
        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados(){
            int quantidade = Alunos.Count; //retorna o número de elementos da lista
            return quantidade; //todo método diferente de void precisa de return (retorno)
        }

        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno); //o Remove retorna um booleano por isso return o remove
        }

        public void ListarAlunos(){
            Console.WriteLine($"Alunos do curso de: {Nome}");
            foreach(Pessoa aluno in Alunos){
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}