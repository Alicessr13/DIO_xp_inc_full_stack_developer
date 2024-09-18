using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
    public class AgendaContext : DbContext //herança de dbcontext, onde tem as operações para trabalhar com banco de dados
    {
        //construtor para conexão com banco de dados
        //recebe a conexão e passa para o base(dbcontext) que inicia a comunicação com o banco de dados
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        //propriedade que refere a entidade(classe e ao mesmo tempo tabela no banco de dados)
        public DbSet<Contato> Contatos { get; set; }
        //está dentro de dbset porque é representado por uma classe no programa e vai ser representado por uma tabela no banco de dados~

        //appsettings onde se cadastra a conexão 
        //appsettings.development se usa para testes
        //appsettings usa para produção

        //"Server=localhost\\sqlexpress; = servidor do banco de dados
        //Initial Catalog=Agenda; = banco de dados que vai ser utilizado, o entity framework cria
        //Integrated Security=True" = autenticação 
    }
}