import { UserService } from './shared/user.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'nov-user',
  templateUrl: './fornecedor.component.html',
  styleUrls: ['./fornecedor.component.scss']
})
export class UserComponent implements OnInit {

  constructor(private userService: UserService) { }

  users: User[] = [];
  editEnable: boolean;
  usuarioEditando: User;

  ngOnInit() {
    this.userService.getAll().subscribe(users => this.users = users);
  }

  criarUsuario(usuario: User) {
    if (this.editEnable) {

      usuario.id = this.usuarioEditando.id;
      console.log(usuario);

      this.userService.atualizar(usuario).subscribe(response => {
        console.log(response);
        this.userService.getAll().subscribe(users => this.users = users);
        this.modoEdicao(false);
      });
    } else {
      this.userService.salvar(usuario).subscribe(response => {
        console.log(response);
        this.userService.getAll().subscribe(users => this.users = users);
      });
    }

  }

  editar(usuario: User) {

    (<HTMLInputElement>document.getElementById('inputNome')).value = usuario.nome;
    (<HTMLInputElement>document.getElementById('inputSenha')).value = usuario.senha;
    (<HTMLInputElement>document.getElementById('inputEmail')).value = usuario.email;

    this.modoEdicao(true);
    this.usuarioEditando = usuario;
  }

  modoEdicao(habilitar: boolean) {
    if (habilitar) {
      this.editEnable = true;
      (<HTMLButtonElement>document.getElementById('btnCriar')).textContent = "Salvar";
    } else {
      this.editEnable = false;
      (<HTMLButtonElement>document.getElementById('btnCriar')).textContent = "Criar";

      (<HTMLInputElement>document.getElementById('inputNome')).value = "";
      (<HTMLInputElement>document.getElementById('inputSobrenome')).value = "";
      (<HTMLInputElement>document.getElementById('inputSenha')).value = "";
      (<HTMLInputElement>document.getElementById('inputEmail')).value = "";
    }
  }

  excluir(id: number) {
    console.log(id);
    this.userService.excluir(id).subscribe(response => {
      console.log(response);
      this.userService.getAll().subscribe(users => this.users = users);
    });
  }
}
