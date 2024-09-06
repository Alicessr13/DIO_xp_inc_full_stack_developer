using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exceções_coleções.models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            Metodo2();
        }

        public void Metodo2()
        {   
            //trata a exceção do método 4
            try{
                Metodo3();
            }catch(Exception ex){
                Console.WriteLine("Exceção tratada " + ex.Message);
            }
            
        }

        public void Metodo3()
        {
            Metodo4();
        }

        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção");
            //throw = jogue de volta para alguém pegar e tratar a exceção (vai tentar achar o catch)
            //ou seja ele vai voltando o código até encontrar um tratamento para a exceção
        }
    }
}