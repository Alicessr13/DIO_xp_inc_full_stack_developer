using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    public class Pessoa
    {
        //abstração de pessoa para classe pessoa
        public string Nome { get; set; }
        public int Idade { get; set; }

        //virtual = método pode ser sobreescrito pela classe filha
        public virtual void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}