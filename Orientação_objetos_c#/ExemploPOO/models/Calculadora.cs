using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;

namespace ExemploPOO.models
{
    //calculadora implementa a interface calculadora
    //não é filha e não herda como na herança, na interface implementa
    public class Calculadora : ICalculadora
    {
        //dividir não precisa ser implementado porque vai usar o método da interface dividir

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}