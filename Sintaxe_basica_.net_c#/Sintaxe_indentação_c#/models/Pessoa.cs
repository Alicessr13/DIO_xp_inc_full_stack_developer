using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sintaxe_indentação_c_.models//namespace = organização das classes, caminho lógico
{
    public class Pessoa //classe de nome pessoa
    //nome de classe utiliza PascalCase, não precisa ser o nome do arquivo físico mas é recomendado ou pelo menos ter relação (sem caracteres especiais, somente _)
    {//inicio classe

        //prop = propriedade, propriedade = características que a pessoa vai ter (nome, idade), se a propriedade não for utilizada não tem sentido existir
        //nome de propriedade PascalCase, também não deve ser abreviado mesmo que o nome fique grande (sem caracteres especiais, somente _)
        public string? Nome { get; set; } //get = pegar valor, set = atribuir valor
        // ? para deixar o nome anulavel
        public int Idade { get; set; }



        //metodo = ação que a pessoa pode realizar (função)
        public void Apresentar()
        //nome de metodo PascalCase, (sem caracteres especiais, somente _)
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
            //Console = classe, WriteLine = metodo, conteudo entre as chaves = parametro/argumento
            //  \n pula linha
        }
        
    }//fim classe
}