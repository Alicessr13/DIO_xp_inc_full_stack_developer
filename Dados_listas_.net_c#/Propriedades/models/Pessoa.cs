using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades.models
{
    public class Pessoa
    {
        //propriedades da classe pessoa
        //get = pegar valor, set = atribuir valor
        //nome será armazenado em _nome que é private (somente quem consegue modificar é a propria classe)
        private string _nome;
        public string Nome 
        { 
            get
            {
                //retorna o _nome
                return _nome.ToUpper();
            }
            //quando usar o set
            set{
                //se o valor atribuido(recebido por nome) for vazio gera uma exceção 
                //(vai parar o código, esperrar a exceção ser tratada e se não tratar encerra o código)
                if(value == ""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                //_nome vai receber o valor
                _nome = value;
            }
        }
        

        public int Idade { get; set; }

        public void Apresentar(){
            Console.WriteLine($"Nome: {Nome}, Idade {Idade}");
        }
    }
}