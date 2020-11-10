
import { EmpresaConsultaComponent } from './creditos/empresa-consulta/empresa-consulta.component';
import { EmpresaRegistroComponent } from './creditos/empresa-registro/empresa-registro.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
{
path: 'empresaConsulta',
component: EmpresaConsultaComponent
},
{
path: 'empresaRegistro',
component: EmpresaRegistroComponent
}
];


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
    ],
    exports: [RouterModule]
})
export class AppRoutingModule { }
