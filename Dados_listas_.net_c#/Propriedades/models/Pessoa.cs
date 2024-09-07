using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades.models
{
    public class Pessoa
    {
        //construtor = é chamado quando é criada uma classe, tem sempre o mesmo nome da classe, 
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome; //premeiro nome = propriedade da classe, segundo nome = parametro do construtor
            Sobrenome = sobrenome;
        }
        //pode ter mais de um construtor
        public Pessoa()
        {

        }

        //descontrutor, inverso de construtor, pega os valores e coloca em váriaveis (descontruindo em uma varíavel)
        public void Deconstruct(out string nome, out string sobrenome) //out = parametro de saída
        { 
            nome = Nome;
            sobrenome = Sobrenome;
        }


        //propriedades da classe pessoa
        //get = pegar valor, set = atribuir valor
        //nome será armazenado em _nome que é private (somente quem consegue modificar é a propria classe) 
        //(public = qualquer 1 pode acessar)
        private string _nome;
        public string Nome
        {
            get
            {
                //retorna o _nome
                return _nome.ToUpper();
            }

            //get => _nome.ToUpper(); modo simplificado de escrever o get 

            //set => _nome = value; modo simplificado de escrever o set

            //quando usar o set
            set
            {
                //se o valor atribuido(recebido por nome) for vazio gera uma exceção 
                //(vai parar o código, esperrar a exceção ser tratada e se não tratar encerra o código)
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                //_nome vai receber o valor
                _nome = value;
            }
        }

        private int _idade;


        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
        }

        //public int Idade { get; set; }

        public string Sobrenome { get; set; }

        //propriedade somente leitura, somente get, pode ser combinadas outras propriedades em uma 
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade {Idade}");
        }


    }
}