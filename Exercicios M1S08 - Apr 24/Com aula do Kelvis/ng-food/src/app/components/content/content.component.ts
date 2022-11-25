import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IMenu } from 'src/app/models/menu.model';
import { LISTA_MENUS_MOCK } from '../constants/menus-mock';



@Component({
  selector: 'ngf-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.scss']
})
export class ContentComponent implements OnInit {
  listaMenu: IMenu[] = LISTA_MENUS_MOCK;

  constructor(private route: Router) { }

  ngOnInit(): void {
  }

  redirecionar(path: string){
    this.route.navigateByUrl(path);
  }

}
