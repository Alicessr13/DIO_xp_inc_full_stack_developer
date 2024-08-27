//arquivos de projetos:

//.csproj = contém informações do projeto (build, debug, versão), cada projeto tem 1

//.sln = solution/solução contém informações que corregam um agrupamento de projetos

using Sintaxe_indentação_c_.models;

Console.WriteLine("teste");

//para um projeto reconher outro que esteja na solution precisa adicionar a referencia do projeto no csproj 
//pessoa está em Sintexe_indentação_c# e esse csproj está na solution DIO_xp_inc_full_stack_developer.generated.sln

//se der erro conferir se está certo na solution
Pessoa pessoa = new Pessoa();

//program é o ponto de entrada do projeto
//versões anteriores do .net(5 e inferior) possui o metodo main no program
//a partir da versão 6 pode digitar o código direto na classe, mas não tem problema colocar o main nas versões superiores
