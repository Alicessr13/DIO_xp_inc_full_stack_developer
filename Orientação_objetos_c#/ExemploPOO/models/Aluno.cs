using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    //para um classe herdar de outra coloca : entre elas exemplo aluno herda de pessoa
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        //override = sobreescrever a classe apresentar
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}");
        }

        //como em pessoa o nome é obrigatório pelo construtor em aluno também é obrigatório
        //quando instanciar a classe aluno também exige nome mas ele é utilizado na classe pai
        public Aluno(string nome) : base(nome)
        {
            
        }

        public Aluno(){
            
        }
    }
}