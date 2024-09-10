using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        private decimal Saldo { get; set; } //encapsulamento, saldo do tipo privado (somente a propria classe pode acessar)
        //para trabalhar com saldo usa as classes para não alterar ele diretamente, saldo está protegido e no sacar ele faz a validação antes de alterar o saldo

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        public void Sacar(decimal valor){
            if(Saldo >= valor){
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else{
                Console.WriteLine("Valor desejado é maior que o saldo disponível");
            }
        }

        public void ExibirSaldo(){
            Console.WriteLine("Seu saldo disponível é: "+Saldo);
        }
    }
}