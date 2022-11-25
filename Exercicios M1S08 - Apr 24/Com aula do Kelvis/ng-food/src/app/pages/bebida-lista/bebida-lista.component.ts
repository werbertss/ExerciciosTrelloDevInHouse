import { Component, OnInit } from '@angular/core';
import { IBebida } from 'src/app/models/bebida.model';
import { BebidaService } from 'src/app/services/bebida.service';

@Component({
  selector: 'ngf-bebida-lista',
  templateUrl: './bebida-lista.component.html',
  styleUrls: ['./bebida-lista.component.scss']
})
export class BebidaListaComponent implements OnInit {
  listaBebida: IBebida[] = [];

  constructor(private bebidaService: BebidaService) { }

  ngOnInit(): void {
    this.buscarBebidas();
  }

  buscarBebidas(){
    this.bebidaService
    .devolverBebidas()
    .subscribe((resposta: IBebida[])=>{
      this.listaBebida = resposta;
    });
  }

  /* adicionarBebidas(){
    const bebida = {
      id: this.listaBebida.length + 1,
      titulo: `BEBIDA ${this.listaBebida.length + 1}`,
      enderecoImagem: 'assets/Bebida.svg',
      descricao: 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Culpa illo sunt, voluptatibus velit maiores sit totam laborum a veniam minima doloribus ducimus est molestiae, error, eaque magni quibusdam voluptatum quod!',
      valor: 15.0,
    };
    
    this.bebidaService.adicionarBebidas(bebida)
    .subscribe((resultado: IBebida) => {
      console.log ('resultado:', resultado);
      this.listaBebida.push(resultado);
    });
  } */

}
