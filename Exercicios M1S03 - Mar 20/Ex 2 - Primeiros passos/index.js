//Um alert
window.alert("Leia com bastante atenção"); 

//Variavel para agragar o valor true ou false, em relação a pergunta do confirm
let resposta = confirm("Deseja continuar no site?"); 
// Se pessoa deseja ficar, ficar no site, se não, ir para outra página teste
if (resposta == false){
  window.location.href = "sair.html"
}else{
}