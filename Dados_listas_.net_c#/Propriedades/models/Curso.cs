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
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count; //retorna o número de elementos da lista
            return quantidade; //todo método diferente de void precisa de return (retorno)
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno); //o Remove retorna um booleano por isso return o remove
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}"); 

            for (int count = 0; count < Alunos.Count; count++)
            {
                //string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto; //concatenando (juntando) um texto com uma porpriedade
                // sinal + com string faz concatenação, se for variavel númerica é realizada soma 

                //ao realizar a concatenação ou interpolação o count é convertido para string

                string texto = $"Nº {count + 1} - {Alunos[count].NomeCompleto}"; //interpolação de string
                //count + 1 não altera o valor da variavel é somente para exibição, count ++ não funciona nesse caso
                Console.WriteLine(texto);
            }
        }
    }
}