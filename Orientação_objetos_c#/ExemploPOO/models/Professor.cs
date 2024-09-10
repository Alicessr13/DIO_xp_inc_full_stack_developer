using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    //para um classe herdar de outra coloca : entre elas exemplo professor herda de pessoa
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }
    }
}