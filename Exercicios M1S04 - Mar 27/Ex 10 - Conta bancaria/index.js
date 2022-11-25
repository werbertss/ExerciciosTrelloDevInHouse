seuId = 2;

const contasClientes = [

    {id: 1, saldo: 500},
    
    {id: 2, saldo: 30000},
    
    {id: 3, saldo: 50},
    
];


console.log(contasClientes.find (contasClientes => contasClientes.id === 2));

const resultado = contasClientes.map (contasClientes. => {
  const novoEstado = {...contasClientes};
  novoEstado.saldo = novoEstado.saldo + 100;
  return novoEstado;
});

console.log (resultado);






/* /* const conta = contasClientes.filter(contasClientes => contasClientes.id == 1);
  console.log (conta); */

 /* if (seuId == 1){
  const conta = contasClientes.filter(contasClientes => contasClientes.id == 1);
  console.log (conta);

  console.log ("Saque:");







}else if (seuId == 2){
  const conta = contasClientes.filter(contasClientes => contasClientes.id == 2);
  console.log (conta);

  console.log ("Saque:");
  const saque = 0;
  let restante = contasClientes.saldo - saque;
  if(contasClientes.saldo < saque){
    console.log("Não da para sacar esse valor " + valor + " , pois ultrapassa o valor que você possui");
  }else{
    console.log ("Valor sacado", restante);
  }






}else if (seuId == 3){
  const conta = contasClientes.filter(contasClientes => contasClientes.id == 3);
  console.log (conta);

  console.log ("Saque:");
}; */



//console.log (contasClientes[seuId-1]);  */