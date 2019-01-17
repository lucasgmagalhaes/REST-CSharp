import { UserService } from './../user/shared/user.service';
import { Authentication } from './../guards/authentication.model';
import { LoginService } from './login.service';
import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Empresa } from '../models/empresa.model';

@Component({
  selector: 'nov-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  empresas: Empresa[];
  empresaSelecionada: Empresa;
  selecionaEmpresa: boolean;

  constructor(private loginService: LoginService, private userService: UserService) { }

  ngOnInit() {
  }

  loginForm = new FormGroup({
    email: new FormControl(''),
    password: new FormControl('')
  });

  login() {
    this.loginService.login(this.loginForm.controls.email.value,
      this.loginForm.controls.password.value).subscribe(response => {

        console.log(response);

        localStorage.setItem("acessToken", response.accessToken);
        localStorage.setItem("IdUsuario", response.idUsuario.toString());

        this.userService.buscarEmpresas(response.idUsuario).subscribe(response => {
          console.log(response);
          this.empresas = response;
          this.selecionaEmpresa = true;
        });
      });
  }

  setEmpresa(empresa: Empresa) {
    this.empresaSelecionada = empresa;
  }

  selecionarEmpresa() {
    localStorage.setItem('empresa', JSON.stringify(this.empresaSelecionada));
    console.log(localStorage.getItem('empresa'));
    document.getElementById('exampleModalCenter').style.visibility = 'none';
  }

}
