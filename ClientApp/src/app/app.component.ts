import { Component } from '@angular/core';
import { Fornecedor } from './user/shared/fornecedor.model';

@Component({
  selector: 'nov-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'ClientApp';

  fornecedores: Fornecedor[];
}
