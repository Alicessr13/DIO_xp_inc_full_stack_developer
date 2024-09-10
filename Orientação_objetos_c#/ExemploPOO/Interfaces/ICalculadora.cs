using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    //sempre coloca i maisculo no nome de uma interface
    public interface ICalculadora
    {
        //não precisa do public (subentendesse que seja public)
        //não precisa de implementação (pode ter)
        //precisa somente nome tipo e os parametros (ou seja assinatura)
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2){
            return num1 / num2;
        }
    }
}