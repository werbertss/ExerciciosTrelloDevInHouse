/* var valorInicial = 1;
var raiz = 3;
var quantidade;
var resultado = valorInicial + raiz;

for (quantidade = 0; quantidade = 10; quantidade++){
    console.log("O resultado é: ", resultado);
    resultado+raiz;
} */



let valorInicial = prompt ("Digite o valor principal: ");
valorInicial = parseInt(valorInicial);
let raiz = prompt("Digite a Raiz: ");
raiz = parseInt(raiz);

for (var i = 0; i <= 9; i++) {
    window.alert("O resultado: "+ valorInicial);
    valorInicial+=raiz;
 }