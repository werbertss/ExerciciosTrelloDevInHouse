import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'esp-tela-principal',
  templateUrl: './tela-principal.component.html',
  styleUrls: ['./tela-principal.component.scss']
})
export class TelaPrincipalComponent implements OnInit {


  ativo: boolean = false;
  tamanhoFonte: number = 10;


  constructor() { }

  ngOnInit(): void {
  }
  

  mudarAtivo(){
    this.ativo = !this.ativo;
  }

}
