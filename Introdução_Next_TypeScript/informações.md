typescript = complemento/SUPERSET do javascipt, adiciona recursos que não tem nativamente
exemplo: tipagem estatica, orientação a objeto, herança

beneficios; detecção de erros e incluir inteligencia da ide

exemplo tipagem estática:
const nome: string = 'Alice';
const idade: number = 26;
const ativo: boolean = false;

inferência de tipos, se passar para uma variavel uma string ele vai reconhecer que é string e sempre será string, mesma coisa com outros tipos

interface, tipar um objeto e os items ficam obrigatórios

interface IUsuario{
    nome: string;
    idade: number;
    ativo: boolean;
}

const usuario: IUsuario = {
    nome: 'Alice',
    idade: 22,
    ativo: true
}

enum:

enum CARGO {
    DESENVOLVEDOR = 'desenvolvedor'
}

const usuario = {
    nome: 'Alice',
    cargo: CARGO.DESENVOLVEDOR
}

precisa instalar o typescript no projeto e executar, cria o arquivo tsconfig.json

tipo do arquivo tsx a inves de jsx
e ts ao inves de js

next.js = framework do react, seu grande diferencial e poder controlar o método de renderização da aplicação
SSR, SPA, SSG

SSR renderização do lado do servidor
SPA renderização do lado do cliente (método padrão do javascript)
SSG pré-renderiza páginas usando geração estática

no next as pastas e arquivos são rotas e pode pegar parametros pela url

next auth biblioteca para api