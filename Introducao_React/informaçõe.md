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