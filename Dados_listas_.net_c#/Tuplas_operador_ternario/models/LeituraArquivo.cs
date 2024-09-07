using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas_operador_ternario.models
{
    public class LeituraArquivo
    {
        //metodo que retorna uma tupla, ou seja mais de uma informação
        public (bool Sucesso, string[] Linha, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);

                //no metodo pede para retornar 3 tipos de dados, então precisa do retorne co 3 tipos de dados
                return (true, linhas, linhas.Count()); //precisa ser na ordem exata, primeiro bool depois string, depois int
            }
            catch(Exception ex){
                //no metodo pede para retornar 3 tipos de dados, então precisa do retorne co 3 tipos de dados
                return(false, new string[0], 0);
            }

        }
    }
}