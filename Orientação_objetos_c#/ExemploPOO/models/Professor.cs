using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    //para um classe herdar de outra coloca : entre elas exemplo professor herda de pessoa
    public sealed class Professor : Pessoa //sealed = classe selada
    {
        public decimal Salario { get; set; }

        public Professor(string nome) : base(nome)
        {
            
        }

        public Professor(){

        }

        //metodo selado = metodo não pode ser sobreescrito pelas classes filhas
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario}");
        }
    }
}