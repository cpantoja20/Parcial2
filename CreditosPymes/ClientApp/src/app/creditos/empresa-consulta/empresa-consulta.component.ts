import { Component, OnInit } from '@angular/core';
import { EmpresasService } from 'src/app/services/empresas.service';
import { Empresas } from '../models/empresas';

@Component({
  selector: 'app-empresa-consulta',
  templateUrl: './empresa-consulta.component.html',
  styleUrls: ['./empresa-consulta.component.css']
})
export class EmpresaConsultaComponent implements OnInit {

  empresas: Empresas[];
  constructor(private empresasService: EmpresasService) { }

  ngOnInit(): void {

    this.empresasService.get().subscribe(result => {
      this.empresas = result;
    });
  }

}
