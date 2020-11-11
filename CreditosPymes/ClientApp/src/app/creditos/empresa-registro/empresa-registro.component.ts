import { Component, OnInit } from '@angular/core';
import { EmpresasService } from 'src/app/services/empresas.service';
import { Empresas } from '../models/empresas';

@Component({
  selector: 'app-empresa-registro',
  templateUrl: './empresa-registro.component.html',
  styleUrls: ['./empresa-registro.component.css']
})
export class EmpresaRegistroComponent implements OnInit {

  empresas: Empresas;
  constructor(private empresasService: EmpresasService) { }

  ngOnInit() {
    this.empresas = new Empresas();
  }

  add() {
    this.empresasService.post(this.empresas).subscribe(p => {
      if (p != null) {
        alert('Guardado con exito!');
        this.empresas = p;
      }
    });

  }
}
