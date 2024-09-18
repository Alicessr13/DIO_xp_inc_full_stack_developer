using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloAPI.Entities
{
    public class Contato
    {
        //espelho para tabela no banco de dados
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }

        //contexto = classe que centraliza as informações em determinado banco de dados
    }
}