import { Pipe, PipeTransform } from '@angular/core';
import { Empresas } from '../creditos/models/empresas';

@Pipe({
  name: 'filtroEmpresa'
})
export class FiltroEmpresaPipe implements PipeTransform {

  transform(empresas: Empresas[], searchText: string): any {
    if (searchText == null) { return empresas; }
    return empresas.filter(p => p.nEmpresa.toLowerCase().indexOf(searchText.toLowerCase()) !== -1);
  }

}
