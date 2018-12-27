import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  salvar(user: User): Promise<Object> {
    return this.http.post('', user).toPromise();
  }
}
