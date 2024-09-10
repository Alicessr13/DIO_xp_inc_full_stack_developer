using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    //abstract = classe abstrata, não pode ser acessada diretamente, somente herdada
    public abstract class Conta
    {
        //protected = protegido quanto a alterações externas com exceção das classe filhas
        protected decimal saldo { get; set; }

        //metodo abstrato = não tem implementação (código), quem herdar a classe conta vai ter que implementar o método
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo(){
            Console.WriteLine("O seu saldo é: "+saldo);
        }
    }
}