import { HttpClient, HttpErrorResponse, HttpStatusCode } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Categoria } from '../models/categories';
import { catchError } from 'rxjs/operators';
import { throwError} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiCallService {

  private endpoint = 'api/Categories';
  constructor(private http: HttpClient) { }

  listarCategorias() : Observable<Categoria[]>{
    return this.http.get<Categoria[]>(environment.callApi + this.endpoint)
           .pipe(
              catchError(this.errorHandler)
           )
  }

  crearCategoria(categoria: Categoria) : Observable<Categoria[]>{
    return this.http.post<Categoria[]>(environment.callApi + this.endpoint, categoria)
          .pipe(
            catchError(this.errorHandler)
          );     
  }

  eliminarCategoria(id: number) : Observable<Categoria[]>{
    return this.http.delete<Categoria[]>(environment.callApi + 'api/Categories/'+ id)
          .pipe(
            catchError(this.errorHandler)
          );
  }

  actualizarCategoria(categoria: Categoria) : Observable<Categoria[]>{
    return this.http.post<Categoria[]>(environment.callApi + 'api/Categories/' + categoria.Id, categoria)
           .pipe(
              catchError(this.errorHandler)
          );
  }

  errorHandler(error: HttpErrorResponse){
      console.log('Error: No se pudo completar la acción requerida', error.message);
      return throwError(() => error);
  }
}
