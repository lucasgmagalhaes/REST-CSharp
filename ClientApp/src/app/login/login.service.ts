import { Authentication } from "./../guards/authentication.model";
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment.prod";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root"
})
export class LoginService {

  constructor(private http: HttpClient) { }

  login(email: string, senha: string): Observable<Authentication> {
    console.log(environment.apiRoute + "autenticacao");
    return this.http.post<Authentication>(environment.apiRoute + "autenticacao",
      { email: email, senha: senha });
  }
}
