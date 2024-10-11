import React from 'react'; // Adicione esta linha
import Button from "./components/Button";

function App() { //componente app
  return ( //componente = função retornando um html, dentro da função o html tem nome jsx, 
    //jsx = tags html dentro de uma função javascript, o javascript faz a conversão para fazer as manipulações
    //não da pra retornar duas tags(lado a lado) no return, para fazer isso deixa eles dentro de uma tag vazia
    <div className="App">
        <h1>Olá react</h1>
        <Button title="Entrar"/> 
        <Button title="Fechar"/> 
        <Button title="Sair"/> 
    </div>
  );//passando valor para title
}

export default App;
