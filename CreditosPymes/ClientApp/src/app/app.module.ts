import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { EmpresaConsultaComponent } from './creditos/empresa-consulta/empresa-consulta.component';
import { EmpresaRegistroComponent } from './creditos/empresa-registro/empresa-registro.component';
import { AppRoutingModule } from './app-routing.module';
import { EmpresasService } from './services/empresas.service';
import { FiltroEmpresaPipe } from './pipe/filtro-empresa.pipe';
import { AlertmodalComponent } from './@base/alert-modal/alertmodal/alertmodal.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    EmpresaConsultaComponent,
    EmpresaRegistroComponent,
    FiltroEmpresaPipe,
    AlertmodalComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ]),
    AppRoutingModule
  ],
  providers: [EmpresasService],
  bootstrap: [AppComponent]
})
export class AppModule { }
