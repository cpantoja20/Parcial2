import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { EmpresasService } from 'src/app/services/empresas.service';
import { Empresas } from '../models/empresas';

@Component({
  selector: 'app-empresa-registro',
  templateUrl: './empresa-registro.component.html',
  styleUrls: ['./empresa-registro.component.css']
})
export class EmpresaRegistroComponent implements OnInit {

  formGroup: FormGroup;
  empresas: Empresas;
  submitted: boolean;
  constructor(private empresasService: EmpresasService, private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.empresas = new Empresas();
    this.buildForm();
  }
  private buildForm() {
    this.empresas = new Empresas();
    this.empresas.idEmpresa = '';
    this.empresas.nEmpresa = '';
    this.empresas.cEmpleados = 0;
    this.empresas.vrActivos = 0;
    this.empresas.tipoEmpresa = '';
    this.empresas.creditoEmpresa = '';

    this.formGroup = this.formBuilder.group({
      // tslint:disable-next-line:max-line-length
      idEmpresa: [this.empresas.idEmpresa, [Validators.required, Validators.minLength(7), Validators.maxLength(13), Validators.pattern('^[0-9]+$')]],
      nEmpresa: [this.empresas.nEmpresa, [Validators.required, Validators.minLength(4)]],
      cEmpleadosp: [this.empresas.cEmpleados, [Validators.required, Validators.minLength(1)]],
      vrActivo: [this.empresas.vrActivos, [Validators.required, Validators.minLength(1)]],
      tipoEmpresa: [this.empresas.tipoEmpresa, [Validators.required, Validators.minLength(1)]]
    });
  }

  get control() {
    return this.formGroup.controls;
  }

  onSubmit() {
    this.submitted = true;
    // stop here if form is invalid
    if (this.formGroup.invalid) {
      return;
    }
    this.add();
  }

  add() {
    this.empresas = this.formGroup.value;
    this.empresasService.post(this.empresas).subscribe(p => {
      if (p != null) {
        alert('Guardado con exito!');
        this.empresas = p;
      }
    });
  }
}

