import { HttpClient, HttpHandler } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError, map, tap} from 'rxjs/operators';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Empresas } from '../creditos/models/empresas';

@Injectable({
  providedIn: 'root'
})
export class EmpresasService {

  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {
    this.baseUrl = baseUrl;
  }
  get(): Observable<Empresas[]> {
    return this.http.get<Empresas[]>(this.baseUrl + 'api/Empresas')
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Empresas[]>('Consulta Empresas', null))
      );
  }
  post(empresas: Empresas): Observable<Empresas> {
    return this.http.post<Empresas>(this.baseUrl + 'api/Empresas', empresas)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Empresas>('Registrar Empresas', null))
      );
  }

}
