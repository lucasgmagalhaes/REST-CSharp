import { UserService } from './../user/shared/user.service';
import { Authentication } from './../guards/authentication.model';
import { LoginService } from './login.service';
import { Component, OnInit, OnDestroy, Output } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Empresa } from '../models/empresa.model';
import { FornecedorService } from '../user/shared/fornecedor.service';
import { Fornecedor } from '../user/shared/fornecedor.model';

@Component({
  selector: 'nov-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  empresas: Empresa[];
  empresaSelecionada: Empresa;
  selecionaEmpresa: boolean;

  loginForm = new FormGroup({
    email: new FormControl(''),
    password: new FormControl('')
  });

  @Output()
  fornecedores: Fornecedor[];

  constructor(private loginService: LoginService, private userService: UserService,
    private fornecedorService: FornecedorService) { }

  ngOnInit() {
  }

  login() {
    this.loginService.login(this.loginForm.controls.email.value,
      this.loginForm.controls.password.value).subscribe(authenticacao => {

        console.log(authenticacao);

        localStorage.setItem('usuarioLogado', JSON.stringify(authenticacao));

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
    this.loginService.setEmpresa(this.empresaSelecionada.nome).subscribe(() => {
      localStorage.setItem('empresa', this.empresaSelecionada.nome);
      console.log(localStorage.getItem('empresa'));
      document.getElementById('exampleModalCenter').style.visibility = 'none';

      this.fornecedorService.getAll().subscribe(fornecedores => {
        this.fornecedores = fornecedores;
      });

    });
  }

}
