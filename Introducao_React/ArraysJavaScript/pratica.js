//map utilizando this como parametro
const maca = {
    value: 2,
}

const laranja = {
    value: 3,
}

function mapComThis(arr, thisArg){
    return arr.map(function(item){
        return item * this.value;
    }, thisArg);
}

const nums = [1, 2];

console.log('quando this = maca: ',mapComThis(nums,maca));

console.log('quando this = laranja: ',mapComThis(nums,laranja));

//map sem utilizar this como parametro
function mapSemThis(arr){
    return arr.map(function(item){
        return item * 2;
    });
}

const nums2 = [2, 4, 6, 8, 10];

console.log('map sem this: ',mapSemThis(nums2));

//filter 
function filtraPares(arr){
    return arr.filter(callback);
}

function callback(item){
    return item % 2 === 0;
}

const meuArray = [1, 23, 55, 67, 30, 2, 4];

console.log("Filter: ",filtraPares(meuArray));

//reduce 
function somaNumeros(arr){
    return arr.reduce(function(prev, current){
        console.log({prev});
        console.log({current});
        return prev + current; //soma o valor anterior com o valor atual
    })
}

const arr = [1, 2];

console.log('Reduce: ', somaNumeros(arr)); //somou prev + current

//reduce 2
const lista = [
    {
        name: 'sabao em po',
        preco: 30
    },
    {
        name: 'cereal',
        preco: 12
    },
    {
        name: 'toalha',
        preco: 30
    }
];

const saldoDisponivel = 100;

function calculaSaldo(saldoDisponivel, lista){
    return lista.reduce(function(prev, current, index){
        console.log("Rodada ", index + 1);
        console.log({prev});
        console.log({current});
        return prev - current.preco;
    }, saldoDisponivel); //inicia prev com o valor de saldoDisponivel, 
}

console.log(calculaSaldo(saldoDisponivel, lista));

//executar sem html node pratica.js