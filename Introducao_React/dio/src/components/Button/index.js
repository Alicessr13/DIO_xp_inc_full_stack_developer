import React from 'react'; // Adicione esta linha

export default function Button({title}) { //recebe a propriedade e faz a desestruturação
    //const {title} = props; //desestruturação, title está dentro de props/propriedade

  return (
    <button>{title}</button>
  )
}
