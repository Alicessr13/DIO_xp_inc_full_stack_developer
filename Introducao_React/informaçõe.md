npx = baixa sempre do repositórioa versão mais recente

para criar projeto react, dio = nome do projeto
npx create-react-app dio

node_modules = bibliotecas e dependencias
public = arquivos principais do react (estrutura pwa, renderização cliente/componentes)

index.js = ponto de entrada da aplicação

package.json = arquivo para utilizar as dependencias 

componentes sempre começa com letra maiscula, tudo é componente no react, a página e os elementos dentro dela, reutilizar os componentes

existem componentes de classe e de funções, mais usado atualmente e de funções

ao referenciar somente a pasta ele importa o index por padrão

rfc cria a estrutura do componente

npm run start executar

iniciar projeto node.js
npm init -y

instalar babel npm install @babel/core @babel/preset-env @babel/preset-react babel-loader --save-dev
arquivo .babelrc
{
  "presets": [
    "@babel/preset-env",
    "@babel/preset-react"
  ]
}

adicionar react ao projeto npm install react react-dom

Eslint ajuda a manter um padrão de escrita de código

prettier usa com o eslint, editorconfig

funções para array

map = não modifica o array original, cria um novo, realiza as operações em ordem
recebe 2 parametros, callback(função a ser executada em cada elemento) e thisArg (opcional)
parecido com foreach
exemplo: const array [1, 2, 3, 4, 5];
array.map((item)=> item *2);
retorno: [2, 4, 6, 8, 10];

filter = só retorna os itens que correspondem a determinada condição, retorna em um novo array
também recebe 2 parametros callback e thisArg
exemplo: const frutas ['maça fuji', 'maça verde', 'laranja', 'abacaxi'];
frutas.filter((fruta) => fruta.includes('maça'));
retorno: ['maça fuji', 'maça verde'];

reduce = executa uma função em todos os elementos do array, retornando um valor único
também recebe 2 parametros callback e initialValue
callback: função a ser executada a partir do acumulador
initialValue: valor sobre o qual o retorno final irá atuar (opcional)
