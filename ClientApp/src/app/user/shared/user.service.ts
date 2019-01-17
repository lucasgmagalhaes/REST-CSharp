import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Empresa } from 'src/app/models/empresa.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  salvar(user: User): Observable<Object> {
    return this.http.post(environment.apiRoute + 'usuario/', user, { responseType: 'text' });
  }

  atualizar(user: User): Observable<Object> {
    console.log(user);
    return this.http.put(environment.apiRoute + 'usuario/', user, { responseType: 'text' });
  }

  getAll(): Observable<User[]> {
    return this.http.get<User[]>(environment.apiRoute + 'usuario/');
  }

  excluir(id: number): Observable<Object> {
    console.log(environment.apiRoute + 'usuario/' + id);
    return this.http.delete(environment.apiRoute + 'usuario/' + id);
  }

  buscarEmpresas(id: number): Observable<Empresa[]>{
    return this.http.get<Empresa[]>(environment.apiRoute + 'usuario/' + id + '/empresa');
  }
}
