const titulo = document.querySelector("#titulo");
console.log (titulo.innerHTML);

const descricao = document.querySelector("#descricao");
console.log (descricao.innerHTML);

const listaItens = document.querySelectorAll('.itens');
for (var i=0; i<listaItens.length; i++){
    console.log (listaItens[i].innerHTML);
}
