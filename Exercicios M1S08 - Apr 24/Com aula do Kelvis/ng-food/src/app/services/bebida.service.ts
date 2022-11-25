import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { IBebida } from '../models/bebida.model';

 
@Injectable({
  providedIn: 'root'
})
export class BebidaService {

  bebidas: IBebida[] = [
    {
      id: 1,
      titulo: 'BEBIDA 1',
      enderecoImagem: 'assets/Bebida.svg',
      descricao: 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Culpa illo sunt, voluptatibus velit maiores sit totam laborum a veniam minima doloribus ducimus est molestiae, error, eaque magni quibusdam voluptatum quod!',
      valor: 10.00,
    },
    {
      id: 2,
      titulo: 'BEBIDA 2',
      enderecoImagem: 'assets/Bebida.svg',
      descricao: 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Culpa illo sunt, voluptatibus velit maiores sit totam laborum a veniam minima doloribus ducimus est molestiae, error, eaque magni quibusdam voluptatum quod!',
      valor: 14.00,
    },
    {
      id: 3,
      titulo: 'BEBIDA 3',
      enderecoImagem: 'assets/Bebida.svg',
      descricao: 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Culpa illo sunt, voluptatibus velit maiores sit totam laborum a veniam minima doloribus ducimus est molestiae, error, eaque magni quibusdam voluptatum quod!',
      valor: 15.00,
    },
  ];

  constructor(private http: HttpClient) { }

  getBebidas(){
    return this.bebidas;
  }

  devolverBebidas(): Observable<IBebida[]>{
    return this.http
    .get<IBebida[]>('http://localhost:3000/bebidas');
  }

  adicionarBebidas(bebida: IBebida): Observable<IBebida>{
    return this.http
    .post<IBebida>('http://localhost:3000/bebidas', bebida);
  }

  deletarBebida(id: number): Observable<IBebida>{
    return this.http
    .delete<IBebida>(`http://localhost:3000/unidades/${id}`);
  }

}
