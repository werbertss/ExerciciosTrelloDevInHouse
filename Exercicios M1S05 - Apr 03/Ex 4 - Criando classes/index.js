class Pedidos {
  numeroPedido= "";
  dataPedido;
  estaPago = false;
  listaProdutos;
  nomeCliente;
}

    constructor(nPedido, dPedido, ePago, lProdutos, nCliente) {
      this.numeroPedido = nPedido;
      this.dataPedido = dPedido;
      this.estaPago = ePago;
      this.listaProdutos = lProdutos;
      this.nomeCliente = nCliente;
    }


  let myCar = new Pedidos (218, "Marco", "False", "asd", 55)