import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Fornecedor } from './fornecedor.model';
import { environment } from 'src/environments/environment.prod';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FornecedorService {

  constructor(private http: HttpClient) { }

  criar(fornecedor: Fornecedor): Observable<Fornecedor> {
    return this.http.post<Fornecedor>(environment.apiRoute + 'fornecedor/', fornecedor);
  }

  getAll(): Observable<Fornecedor[]> {
    return this.http.get<Fornecedor[]>(environment.apiRoute + 'fornecedor/');
  }

  excluir(id: number) {
    return this.http.delete<Fornecedor>(environment.apiRoute + `fornecedor/${id}`);
  }
}
