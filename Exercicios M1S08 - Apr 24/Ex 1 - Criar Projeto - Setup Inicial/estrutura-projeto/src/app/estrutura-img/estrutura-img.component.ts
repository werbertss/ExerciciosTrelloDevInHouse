import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'ngf-estrutura-img',
  templateUrl: './estrutura-img.component.html',
  styleUrls: ['./estrutura-img.component.scss']
})
export class EstruturaImgComponent implements OnInit {


  exibirComidas(){
    alert("Pizza, Hamburguer, Cachorro Quente.");
  }
  exibirBebidas(){
    alert("Café, Suco, Refri Gerante.")
  }

  constructor() { }

  ngOnInit(): void {
    const ComidasEbebidas = [
      {
        titulo: 'Comidas',
        imagem: 'assets/Comida.svg',
        rota: 'comidas'
      },
      {
        titulo: 'Bebidas',
        imagem: 'assets/Bebida.svg',
        rota: 'bebidas'
      },
    ];
  }

}
