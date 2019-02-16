import { UserService } from "./../user/shared/user.service";
import { Authentication } from "./../guards/authentication.model";
import { LoginService } from "./login.service";
import { Component, OnInit, OnDestroy } from "@angular/core";
import { FormControl, FormGroup } from "@angular/forms";
import { Empresa } from "../models/empresa.model";

@Component({
  selector: "nov-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.scss"]
})
export class LoginComponent implements OnInit {

  empresas: Empresa[];
  empresaSelecionada: Empresa;
  selecionaEmpresa: boolean;

  loginForm = new FormGroup({
    email: new FormControl(""),
    password: new FormControl("")
  });

  constructor(private loginService: LoginService, private userService: UserService) { }

  ngOnInit() {
  }

  login() {
    this.loginService.login(this.loginForm.controls.email.value,
      this.loginForm.controls.password.value).subscribe(authenticacao => {

        console.log(authenticacao);

        localStorage.setItem("usuarioLogado", JSON.stringify(authenticacao));

        this.userService.buscarEmpresas(authenticacao.idUsuario).subscribe(empresa => {
          console.log(empresa);
          this.empresas = empresa;
          this.selecionaEmpresa = true;
        });
      });
  }

  setEmpresa(empresa: Empresa) {
    this.empresaSelecionada = empresa;
  }

  selecionarEmpresa() {
    localStorage.setItem("empresa", this.empresaSelecionada.nome);
    console.log(localStorage.getItem("empresa"));
    document.getElementById("exampleModalCenter").style.visibility = "none";
  }

}
