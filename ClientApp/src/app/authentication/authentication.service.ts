import { Authentication } from "./../guards/authentication.model";
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
  providedIn: "root"
})
export class AuthenticationService {

  constructor(private http: HttpClient) { }

  login(username: string, password: string) {
    return this.http.post<Authentication>("/api/autenticacao",
     { username: username, password: password }).subscribe(response => {
      // login successful if there"s a jwt token in the response
      if (response && response.accessToken) {
        // store user details and jwt token in local storage to keep user logged in between page refreshes
        localStorage.setItem("usuarioLogado", JSON.stringify(response));
      }
      return response;
    });
  }

  logout() {
    // remove user from local storage to log user out
    localStorage.removeItem("currentUser");
  }
}
