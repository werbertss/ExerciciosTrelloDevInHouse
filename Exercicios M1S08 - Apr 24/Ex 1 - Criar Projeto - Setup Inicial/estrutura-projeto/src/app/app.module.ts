import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { EstruturaImgComponent } from './estrutura-img/estrutura-img.component';

@NgModule({
  declarations: [
    AppComponent,
    EstruturaImgComponent,
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
