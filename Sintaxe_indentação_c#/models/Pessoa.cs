using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sintaxe_indentação_c_.models
{
    public class Pessoa
    {
        //prop = propriedade, propriedade = características que a pessoa vai ter
        public String Nome { get; set; }
        public int Idade { get; set; }

        //metodo = ação que a pessoa pode realizar
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}