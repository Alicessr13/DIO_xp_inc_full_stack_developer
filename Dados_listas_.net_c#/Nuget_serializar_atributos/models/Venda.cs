using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json; //para usar o pacote

namespace Nuget_serializar_atributos.models
{
    public class Venda
    {
        public int Id { get; set; }

        //[JsonProperty("Nome_Produto")] 
        // minha propriedade e produto mas vai vir no arquivo json como Nome_Produto, ou seja mesmo sendo diferente vai reconhecer
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

        public Venda(int id, string produto, decimal preco, DateTime dataVenda){
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }
    }
}