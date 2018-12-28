import { UserService } from './shared/user.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'nov-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent implements OnInit {

  constructor(private userService: UserService) { }

  ngOnInit() {
  }

  criar(nome, email, senha) {
    this.userService.salvar({ userName: nome, email: email, userPassword: senha });
  }
}
