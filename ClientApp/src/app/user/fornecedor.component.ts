import { Component, OnInit, Input } from '@angular/core';
import { Fornecedor } from './shared/fornecedor.model';
import { FornecedorService } from './shared/fornecedor.service';

@Component({
  selector: 'nov-user',
  templateUrl: './fornecedor.component.html',
  styleUrls: ['./fornecedor.component.scss']
})
export class UserComponent implements OnInit {

  constructor(private fornecedorService: FornecedorService) { }

  @Input()
  fornecedores: Fornecedor[] = [];
  editEnable: boolean;
  usuarioEditando: User;

  ngOnInit() {
    this.fornecedorService.getAll().subscribe(fornecedores => this.fornecedores = fornecedores);
  }

  criarFornecedor(fornecedor: Fornecedor) {
    if (this.editEnable) {

      fornecedor.id = this.usuarioEditando.id;
      console.log(fornecedor);

      this.modoEdicao(false);

    } else {
      this.fornecedorService.criar(fornecedor).subscribe(fornecedorCriado => {
        this.fornecedores.push(fornecedorCriado);
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
      (<HTMLButtonElement>document.getElementById('btnCriar')).textContent = 'Salvar';
    } else {
      this.editEnable = false;
      (<HTMLButtonElement>document.getElementById('btnCriar')).textContent = 'Criar';

      (<HTMLInputElement>document.getElementById('inputNome')).value = '';
      (<HTMLInputElement>document.getElementById('inputSobrenome')).value = '';
      (<HTMLInputElement>document.getElementById('inputSenha')).value = '';
      (<HTMLInputElement>document.getElementById('inputEmail')).value = '';
    }
  }

  excluir(id: number) {
    console.log(id);
    this.fornecedorService.excluir(id).subscribe(() => {
      this.fornecedores = this.fornecedores.filter(fornecedor => fornecedor.id !== id);
    });
  }
}
