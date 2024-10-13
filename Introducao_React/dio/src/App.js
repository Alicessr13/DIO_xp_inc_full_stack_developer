import React, { useState, useEffect } from 'react';
import Button from "./components/Button";

function App() { //componente app
  //ciclo de vida do componente, ele tem um estado e a cada alteração de estado tem um efeito colateral que é a renderização em tela
  const arr = [1, 2, 3, 4, 5, 6, 7, 8, 9]

  const [usuario, setUsuario] = useState(""); //inicia vazio

  const [count, setCount] = useState(0); //inicia em zero

  const [usuarios, setUsuarios] = useState(["Pablo", "Jose", "Manoel"]); //usestate = função que tem um estado inicial, quando for renderizado na tela vai ter esse valor
  //retorna o estado (usuarios) e uma função para mudar o estado
  //estado não é mutavel diretamente somente pela função

  const handleAddUser = () => {
    // cria um novo array ... = copia o valor de usuarios, e adiciona o usuário
    setUsuarios([...usuarios, usuario]);
    setUsuario(""); //fica vazio novamente
  }//toda vez que altera o valor de input renderiza porque foi realizada uma ação que precisa renderizar, renderiza o componente inteiro 

  //useEffect a partir de algum efeito da pagina ele faz uma ação
  //useEffect(() => {
  //  setTimeout(() => {
  //    setUsuarios([...usuarios, 'Alice'])
  //  },
  //  3000);
  //});

  useEffect(()=>{ //no primeiro parametro recebe uma função 
    setCount(usuarios.length);
  }, //no segundo parametro recebe um array de dependencias, quando está vazio só é executado quando o componente é montado em tela (inicialização)
  [usuarios]) //toda vez que o array de usuarios for atualizado executa a função

  return ( //componente = função retornando um html, dentro da função o html tem nome jsx, 
    //jsx = tags html dentro de uma função javascript, o javascript faz a conversão para fazer as manipulações
    //não da pra retornar duas tags(lado a lado) no return, para fazer isso deixa eles dentro de uma tag vazia <> </>

    <div className="App">
      <h1>Olá react</h1>
      <Button title="Entrar" />
      <Button title="Fechar" />
      <Button title="Sair" />

      <h3>Total de usuários {count}</h3>
      <input 
      value={usuario} //input tem valor de usuario
      onChange={(event)=>setUsuario(event.target.value)} //toda vez que altera o texto do input altera o valor do estado e input tem novo valor
      >
      </input>
      <button onClick={handleAddUser}>Adicionar</button> 

      {
        arr.map(
          (item) => (
            (<p>{item} * 5 = {item * 5}</p>)
          )
        )
      }

      {
        usuarios.map((item) => (
          <p>{item}</p>
        ))
      }

    </div>
  );//passando valor para title, dentro de {} ele reconhece como código javascript
}

export default App;
